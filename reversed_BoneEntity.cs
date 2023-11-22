        // Sen dönene kadar alışırım yanlızlığa ama sensizliğe alışamam.



        /*junk_method*/
        /*junk_struct*/

        [StructLayout(LayoutKind.Explicit)]
        public struct /*rnd*/CModelState/*rnd*/
        {
            // Token: 0x04000042 RID: 66
            [FieldOffset(128)]
            public long /*rnd*/m_boneArray/*rnd*/;
        }

        /*junk_struct*/

        [StructLayout(LayoutKind.Explicit)]
        public struct /*rnd*/CSkeletonInstance/*rnd*/
        {
            // Token: 0x04000041 RID: 65
            [FieldOffset(352)]
            public /*rnd*/CModelState/*rnd*/ /*rnd*/m_modelState/*rnd*/;
        }

        /*junk_struct*/

        // Token: 0x0200000E RID: 14
        public struct /*rnd*/CBoneData/*rnd*/
        {
            // Token: 0x04000043 RID: 67
            public /*rnd*/math/*rnd*/./*rnd*/Vec3/*rnd*/ /*rnd*/Location/*rnd*/;

            // Token: 0x04000044 RID: 68
            public float /*rnd*/Scale/*rnd*/;

            // Token: 0x04000045 RID: 69
            public /*rnd*/math/*rnd*/./*rnd*/Vec3/*rnd*/ /*rnd*/Rotation/*rnd*/;
        }

        /*junk_struct*/

        /*junk_class*/

        public class /*rnd*/BoneVec/*rnd*/
        {
            // Token: 0x17000002 RID: 2
            // (get) Token: 0x06000011 RID: 17 RVA: 0x00002364 File Offset: 0x00000564
            // (set) Token: 0x06000012 RID: 18 RVA: 0x0000236C File Offset: 0x0000056C
            public bool /*rnd*/Visible/*rnd*/ { get; set; }

            // Token: 0x0400001C RID: 28
            public /*rnd*/math/*rnd*/./*rnd*/Vec3/*rnd*/ /*rnd*/WorldPos/*rnd*/;

            // Token: 0x0400001D RID: 29
            public /*rnd*/math/*rnd*/./*rnd*/Vec2/*rnd*/ /*rnd*/ScreenPos/*rnd*/;
        }

        /*junk_class*/

        /*junk_method*/
        public static /*rnd*/BoneVec/*rnd*/[] /*rnd*/PlayerBoneArray/*rnd*/ = new /*rnd*/BoneVec/*rnd*/[/*number*/116/*number*/];
        /*junk_method*/




        // read test

        long /*rnd*/listEntry/*rnd*/ = /*rnd*/memory/*rnd*/./*rnd*/Read/*rnd*/<long>((ulong)(/*rnd*/entitylistpointer/*rnd*/ + (8 * (/*rnd*/a/*rnd*/ & 0x7FFF) >> 9) + 16));
        if (/*rnd*/listEntry/*rnd*/ == 0) continue;

        ulong /*rnd*/player/*rnd*/ = /*rnd*/memory/*rnd*/./*rnd*/Read/*rnd*/<ulong>((ulong)(/*rnd*/listEntry/*rnd*/ + 120 * (/*rnd*/a/*rnd*/ & 0x1FF)));
        if ( /*rnd*/player/*rnd*/ == 0 ) continue;
