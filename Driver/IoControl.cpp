__int64 __fastcall IoControl(_DEVICE_OBJECT *DeviceObject, _IRP *Irp)
{
  unsigned int *MasterIrp; // rsi
  unsigned int v4; // esi
  unsigned __int64 v5; // rdi
  _KPROCESS *Process; // [rsp+38h] [rbp+10h] BYREF

  if ( Irp->Tail.Overlay.CurrentStackLocation->Parameters.Read.ByteOffset.LowPart == /*custom*/)
  {
    MasterIrp = (unsigned int *)Irp->AssociatedIrp.MasterIrp;
    if ( (int)PsLookupProcessByProcessId(*MasterIrp, &Process) >= 0 )
      KeReadVirtualMemory(Process, (void *)MasterIrp[1], MasterIrp + 2, MasterIrp[3]);
    v4 = 0;
    v5 = 16i64;
  }
  else
  {
    v4 = -1073741811;
    v5 = 0i64;
  }
  Irp->IoStatus.Status = v4;
  Irp->IoStatus.Information = v5;
  IofCompleteRequest(Irp, 0i64);
  return v4;
}
