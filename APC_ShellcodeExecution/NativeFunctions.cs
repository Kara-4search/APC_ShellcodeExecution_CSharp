using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static APC_ShellcodeExecution.NativeStructs;

namespace APC_ShellcodeExecution
{
    class NativeFunctions
    {

        [DllImport("ntdll.dll")]
        public static extern NTSTATUS NtTestAlert();


        [DllImport("kernel32.dll")]
        public static extern IntPtr VirtualAlloc(
            UInt32 lpStartAddr,
            UInt32 size,
            UInt32 flAllocationType,
            AllocationProtect flProtect
        );

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetCurrentThread();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern UInt32 QueueUserAPC(IntPtr pfnAPC, IntPtr hThread, UInt32 dwData);

    }
}
