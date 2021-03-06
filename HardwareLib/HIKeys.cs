using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareLib
{
    public enum HIKeys
    {
        Win32_1394Controller,
        Win32_1394ControllerDevice,
        Win32_BaseBoard,
        Win32_Battery,
        Win32_BIOS,
        Win32_Bus,
        Win32_CDROMDrive,
        Win32_CIMLogicalDeviceCIMDataFile,
        Win32_DeviceBus,
        Win32_DeviceMemoryAddress,
        Win32_DeviceSettings,
        Win32_DisplayConfiguration,
        Win32_DisplayControllerConfiguration,
        Win32_DMAChannel,
        Win32_DriverVXD,
        Win32_FloppyController,
        Win32_FloppyDrive,
        Win32_HeatPipe,
        Win32_IDEController,
        Win32_IDEControllerDevice,
        Win32_InfraredDevice,
        Win32_IRQResource,
        Win32_Keyboard,
        Win32_MotherboardDevice,
        Win32_OnBoardDevice,
        Win32_PCMCIAController,
        Win32_PNPAllocatedResource,
        Win32_PnPDevice,
        Win32_PnPEntity,
        Win32_PointingDevice,
        Win32_PortableBattery,
        Win32_PortConnector,
        Win32_PortResource,
        Win32_POTSModem,
        Win32_POTSModemToSerialPort,
        Win32_PowerManagementEvent,
        Win32_Printer,
        Win32_PrinterConfiguration,
        Win32_PrinterController,
        Win32_PrinterDriverDll,
        Win32_PrinterSetting,
        Win32_PrinterShare,
        Win32_PrintJob,
        Win32_Processor,
        Win32_SCSIController,
        Win32_SCSIControllerDevice,
        Win32_SerialPort,
        Win32_SerialPortConfiguration,
        Win32_SerialPortSetting,
        Win32_SMBIOSMemory,
        Win32_SoundDevice,
        Win32_TemperatureProbe,
        Win32_USBController,
        Win32_USBControllerDevice,
        Win32_VideoConfiguration,
        Win32_VideoController,
        Win32_VideoSettings,
        Win32_VoltageProbe,
    }
    public static class GHIKeys
    {
        public static string GetKey(HIKeys hIKeys)
        {
            return hIKeys.ToString();
        }

    }

}
