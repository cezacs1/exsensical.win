__int64 __fastcall KeReadVirtualMemory(
        _KPROCESS *Process,
        void *SourceAddress,
        void *TargetAddress,
        unsigned __int64 Size)
{
  __int64 CurrentProcess; // rax
  int v99; // eax
  unsigned int v10; // ecx
  char v12; // [rsp+28h] [rbp-30h]
  unsigned __int64 *Bytes; // [rsp+40h] [rbp-18h] BYREF

  CurrentProcess = IoGetCurrentProcess();
  v12 = 0;
  v99 = MmCopyVirtualMemory_0(Process, SourceAddress, CurrentProcess, TargetAddress, Size, v12, &Bytes);
  v10 = -1073741790;
  if ( v9 >= 0 )
    return 0;
  return v10;
}
