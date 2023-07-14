using System;

namespace Dpr.Battle.Logic
{
    public struct BTL_SICKCONT
    {
        public byte type
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte causePokeID
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte turn_type_turn
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte turn_causePokeID
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte turn_count
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public ushort turn_param
        {
            get
            {
                return default(ushort);
            }
            set
            {
            }
        }

        public bool turn_flag
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public byte poke_type_poke
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte poke_causePokeID
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte poke_ID
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public ushort poke_param
        {
            get
            {
                return default(ushort);
            }
            set
            {
            }
        }

        public bool poke_flag
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public byte permanent_type_perm
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte permanent_causePokeID
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte permanent_count_max
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public ushort permanent_param
        {
            get
            {
                return default(ushort);
            }
            set
            {
            }
        }

        public bool permanent_flag
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public byte poketurn_type_poketurn
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte poketurn_causePokeID
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte poketurn_count
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public byte poketurn_pokeID
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public ushort poketurn_param
        {
            get
            {
                return default(ushort);
            }
            set
            {
            }
        }

        public bool poketurn_flag
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public long raw;

        private const int raw_sz0 = 3;

        private const int raw_loc0 = 0;

        private const int raw_sz1 = 5;

        private const int raw_loc1 = 3;

        private const long raw_mask0 = 7L;

        private const long raw_mask1 = 248L;

        private const int turn_sz0 = 3;

        private const int turn_loc0 = 0;

        private const int turn_sz1 = 5;

        private const int turn_loc1 = 3;

        private const int turn_sz2 = 6;

        private const int turn_loc2 = 8;

        private const int turn_sz3 = 16;

        private const int turn_loc3 = 14;

        private const int turn_sz4 = 1;

        private const int turn_loc4 = 30;

        private const long turn_mask0 = 7L;

        private const long turn_mask1 = 248L;

        private const long turn_mask2 = 16128L;

        private const long turn_mask3 = 1073725440L;

        private const long turn_mask4 = 1073741824L;

        private const int poke_sz0 = 3;

        private const int poke_loc0 = 0;

        private const int poke_sz1 = 5;

        private const int poke_loc1 = 3;

        private const int poke_sz2 = 6;

        private const int poke_loc2 = 8;

        private const int poke_sz3 = 16;

        private const int poke_loc3 = 14;

        private const int poke_sz4 = 1;

        private const int poke_loc4 = 30;

        private const long poke_mask0 = 7L;

        private const long poke_mask1 = 248L;

        private const long poke_mask2 = 16128L;

        private const long poke_mask3 = 1073725440L;

        private const long poke_mask4 = 1073741824L;

        private const int permanent_sz0 = 3;

        private const int permanent_loc0 = 0;

        private const int permanent_sz1 = 5;

        private const int permanent_loc1 = 3;

        private const int permanent_sz2 = 6;

        private const int permanent_loc2 = 8;

        private const int permanent_sz3 = 16;

        private const int permanent_loc3 = 14;

        private const int permanent_sz4 = 1;

        private const int permanent_loc4 = 30;

        private const long permanent_mask0 = 7L;

        private const long permanent_mask1 = 248L;

        private const long permanent_mask2 = 16128L;

        private const long permanent_mask3 = 1073725440L;

        private const long permanent_mask4 = 1073741824L;

        private const int poketurn_sz0 = 3;

        private const int poketurn_loc0 = 0;

        private const int poketurn_sz1 = 5;

        private const int poketurn_loc1 = 3;

        private const int poketurn_sz2 = 6;

        private const int poketurn_loc2 = 8;

        private const int poketurn_sz3 = 6;

        private const int poketurn_loc3 = 14;

        private const int poketurn_sz4 = 16;

        private const int poketurn_loc4 = 20;

        private const int poketurn_sz5 = 1;

        private const int poketurn_loc5 = 36;

        private const long poketurn_mask0 = 7L;

        private const long poketurn_mask1 = 248L;

        private const long poketurn_mask2 = 16128L;

        private const long poketurn_mask3 = 1032192L;

        private const long poketurn_mask4 = -1048576L;

        private const long poketurn_mask5 = 16L;
    }
}
