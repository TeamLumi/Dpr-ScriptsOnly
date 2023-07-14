from PIL import Image
import numpy as np
from glob import glob
import time
from os import path, remove
import rapidjson as json
from tqdm import tqdm
import re
import asyncio

async def getfps(extensions):
    fps = []
    for ext in extensions:
        fps += glob('Assets/**/**.' + ext, recursive=True)
    return fps

class reSub:
    
    def __init__(self, dict):
        self.dict = dict
        self.regex = re.compile("(%s)" % "|".join(map(re.escape, dict.keys())))
        
    async def replace(self, text):
        return self.regex.subn(lambda mo: self.dict[mo.string[mo.start():mo.end()]], text)

async def getGuid(fp):
    metaPath = fp + '.meta'
    with open(metaPath, 'r') as f:
        guid = f.read().split('\n')[1].split(':')[1].strip()
        f.close()
        return guid

async def getImage(fp):
    img = Image.open(fp)
    img = np.array(img)
    imgHash = hash(img.data.tobytes())
    
    return img, str(imgHash)

async def getImageReplacements():
    uniqueImages = {}
    guidSubs = {}

    deleteImages = []
    imageSet = set()

    i = 0

    fps = await getfps(['png'])

    for fp in tqdm(fps, total=len(fps)):
        img, imgHash = await getImage(fp)
        guid = await getGuid(fp)
        imageSet.add(imgHash)
        if imgHash not in uniqueImages:
            uniqueImages[imgHash] = {'path': fp, 'guid': guid, 'guids': [guid]}
        else:
            guidSubs[guid] = uniqueImages[imgHash]['guid']
            uniqueImages[imgHash]['guids'].append(guid)
            deleteImages.append(fp)

    return guidSubs, deleteImages

async def overwriteGUIDs(fp, reSubs):
    with open(fp, 'r') as f:
        data = f.read()
        f.close()
        
    replaced, count = await reSubs.replace(data)
    
    if count > 0:

        with open(fp, 'w') as f:
            f.write(replaced)
            
    return count

async def replaceGUIDs(guidSubs):
    
    fps = await getfps(['mat'])
    reSubs = reSub(guidSubs)
    
    proceses = []
        
    for fp in tqdm(fps):
        proceses.append(overwriteGUIDs(fp, reSubs))
           
    responses = [await p for p in tqdm(asyncio.as_completed(proceses), total=len(proceses))]
    replacements = sum(responses)
                
    return replacements

async def deleteImages(deleteImages):
    for fp in tqdm(deleteImages):
        metaPath = fp + '.meta'
        if path.exists(fp):
            remove(fp)
        if path.exists(metaPath):
            remove(metaPath)

async def main():
    
    start = time.time()
    
    print('Getting image replacements...')
    guidSubs, deleteFps = await getImageReplacements()
    
    print('Replacing GUIDs...')
    replacements = await replaceGUIDs(guidSubs)
    
    print(f'Replaced {replacements} GUIDs')
    print('Deleting unneeded images and metadata...')
    await deleteImages(deleteFps)
    
    
    
if __name__ == '__main__':
    asyncio.run(main())