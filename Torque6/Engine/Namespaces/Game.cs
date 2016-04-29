using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Game
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Game_SaveJournal(string namedFile);
         private static _Game_SaveJournal _Game_SaveJournalFunc;
         internal static void Game_SaveJournal(string namedFile)
         {
            if (_Game_SaveJournalFunc == null)
            {
               _Game_SaveJournalFunc =
                  (_Game_SaveJournal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Game_SaveJournal"), typeof(_Game_SaveJournal));
            }

            _Game_SaveJournalFunc(namedFile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Game_PlayJournal(string filePath, bool doBreak);
         private static _Game_PlayJournal _Game_PlayJournalFunc;
         internal static void Game_PlayJournal(string filePath, bool doBreak)
         {
            if (_Game_PlayJournalFunc == null)
            {
               _Game_PlayJournalFunc =
                  (_Game_PlayJournal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Game_PlayJournal"), typeof(_Game_PlayJournal));
            }

            _Game_PlayJournalFunc(filePath, doBreak);
         }
      }

      #endregion
      
      #region Functions

      public static void SaveJournal(string namedFile)
      {
         InternalUnsafeMethods.Game_SaveJournal(namedFile);
      }

      public static void PlayJournal(string filePath, bool doBreak)
      {
         InternalUnsafeMethods.Game_PlayJournal(filePath, doBreak);
      }      

      #endregion
   }
}