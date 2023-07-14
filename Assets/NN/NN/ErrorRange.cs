using nn;
public struct ErrorRange
{
    private int _module;
    private int _descriptionBegin;
    private int _descriptionEnd;

    internal ErrorRange(int module, int descriptionBegin, int descriptionEnd)
    {
        _module = module;
        _descriptionBegin = descriptionBegin;
        _descriptionEnd = descriptionEnd;
    }

    public int Module { get { return _module; } }
    public int DescriptionBegin { get { return _descriptionBegin; } }
    public int DescriptionEnd { get { return _descriptionEnd; } }

    public bool Includes(Result result)
    {
        if (result.GetModule() != Module) { return false; }
        int description = result.GetDescription();
        return (DescriptionBegin <= description) && (description < DescriptionEnd);
    }
}
