__int64 __fastcall DriverEntry(_DRIVER_OBJECT *pDriverObject, _UNICODE_STRING *pRegistryPath)
{
  char v4; // [rsp+28h] [rbp-20h]

  RtlInitUnicodeString(&__c, /*Driver Address);
  RtlInitUnicodeString(&__d, /*Driver Address);
  v4 = 0;
  IoCreateDevice(pDriverObject, 0i64, &__c, 34i64, 256, v4, &pDeviceObject);
  IoCreateSymbolicLink(&__d, &__c);
  pDriverObject->MajorFunction[0] = CreateCall;
  pDriverObject->MajorFunction[2] = CreateCall;
  pDriverObject->MajorFunction[14] = (int (__fastcall *)(_DEVICE_OBJECT *, _IRP *))IoControl;
  pDriverObject->DriverUnload = (void (__fastcall *)(_DRIVER_OBJECT *))UnloadDriver;
  pDeviceObject->Flags |= 0x10u;
  pDeviceObject->Flags &= ~0x80u;
  return 0i64;
}
