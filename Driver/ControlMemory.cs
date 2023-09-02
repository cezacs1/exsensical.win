0  0000	ldloca.s	V_3 (3)
1	 0002  initobj	Program/request
2	 0008  ldloca.s	V_3 (3)
3	 000A  ldarg.1
4	 000B	stfld	uint32 Program/request::ID
5	 0010	ldloca.s	V_3 (3)
6	 0012  ldarg.2
7	 0013  call	native int [mscorlib]System.IntPtr::op_Explicit(int32)
8	 0018	stfld	native int Program/request::Address
9	 001D  ldloca.s	V_3 (3)
10	001F	ldc.i4.4
11	0020	stfld	uint32 Program/request::Size
12	0025	ldloc.3
13	0026	stloc.0
14	0027	ldc.i4.0
15	0028	stloc.1
16	0029	ldc.i4.0
17	002A	stloc.2
18	002B	ldarg.0
19	002C	ldc.i4	0x220004
20	0031	ldloca.s	Request (0)
21	0033	ldloc.0
22	0034	call	int32 [mscorlib]System.Runtime.InteropServices.Marshal::SizeOf<valuetype Program/request>(!!0)
23	0039	ldloca.s	Request (0)
24	003B	ldloc.0
25	003C	call	int32 [mscorlib]System.Runtime.InteropServices.Marshal::SizeOf<valuetype Program/request>(!!0)
26	0041	ldloca.s	bytesReturned (2)
27	0043	ldsfld	native int [mscorlib]System.IntPtr::Zero
28	0048	call	bool Program::DeviceIoControl(native int, uint32, valuetype Program/request&, uint32, valuetype Program/request&, uint32, uint32&, native int)
29	004D	brfalse.s	35 (005D) ldstr "Error code: "
30	004F	ldloc.0
31	0050	ldfld	native int Program/request::ret
32	0055	call	int32 [mscorlib]System.IntPtr::op_Explicit(native int)
33	005A	stloc.1
34	005B	br.s	42 (007A) ldloc.1 
35	005D	ldstr	"Error code: "
36	0062	call	int32 [mscorlib]System.Runtime.InteropServices.Marshal::GetLastWin32Error()
37	0067	stloc.s	V_4 (4)
38	0069	ldloca.s	V_4 (4)
39	006B	call	instance string [mscorlib]System.Int32::ToString()
40	0070	call	string [mscorlib]System.String::Concat(string, string)
41	0075	call	void [mscorlib]System.Console::WriteLine(string)
42	007A	ldloc.1
43	007B	ret
