using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiPopUpMenuCtrl : GuiTextCtrl
   {
      
      public GuiPopUpMenuCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiPopUpMenuCtrlCreateInstance());
      }

      public GuiPopUpMenuCtrl(uint pId) : base(pId)
      {
      }

      public GuiPopUpMenuCtrl(string pName) : base(pName)
      {
      }

      public GuiPopUpMenuCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPopUpMenuCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPopUpMenuCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiPopUpMenuCtrlCreateInstance();
         private static _GuiPopUpMenuCtrlCreateInstance _GuiPopUpMenuCtrlCreateInstanceFunc;
         internal static IntPtr GuiPopUpMenuCtrlCreateInstance()
         {
            if (_GuiPopUpMenuCtrlCreateInstanceFunc == null)
            {
               _GuiPopUpMenuCtrlCreateInstanceFunc =
                  (_GuiPopUpMenuCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlCreateInstance"), typeof(_GuiPopUpMenuCtrlCreateInstance));
            }

            return _GuiPopUpMenuCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlAdd(IntPtr ctrl, string entryText, int entryID, int entryScheme);
         private static _GuiPopUpMenuCtrlAdd _GuiPopUpMenuCtrlAddFunc;
         internal static void GuiPopUpMenuCtrlAdd(IntPtr ctrl, string entryText, int entryID, int entryScheme)
         {
            if (_GuiPopUpMenuCtrlAddFunc == null)
            {
               _GuiPopUpMenuCtrlAddFunc =
                  (_GuiPopUpMenuCtrlAdd)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlAdd"), typeof(_GuiPopUpMenuCtrlAdd));
            }

            _GuiPopUpMenuCtrlAddFunc(ctrl, entryText, entryID, entryScheme);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlAddScheme(IntPtr ctrl, int entryScheme, Color fontColor, Color fontColorHL, Color fontColorSEL);
         private static _GuiPopUpMenuCtrlAddScheme _GuiPopUpMenuCtrlAddSchemeFunc;
         internal static void GuiPopUpMenuCtrlAddScheme(IntPtr ctrl, int entryScheme, Color fontColor, Color fontColorHL, Color fontColorSEL)
         {
            if (_GuiPopUpMenuCtrlAddSchemeFunc == null)
            {
               _GuiPopUpMenuCtrlAddSchemeFunc =
                  (_GuiPopUpMenuCtrlAddScheme)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlAddScheme"), typeof(_GuiPopUpMenuCtrlAddScheme));
            }

            _GuiPopUpMenuCtrlAddSchemeFunc(ctrl, entryScheme, fontColor, fontColorHL, fontColorSEL);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlSetText(IntPtr ctrl, string text);
         private static _GuiPopUpMenuCtrlSetText _GuiPopUpMenuCtrlSetTextFunc;
         internal static void GuiPopUpMenuCtrlSetText(IntPtr ctrl, string text)
         {
            if (_GuiPopUpMenuCtrlSetTextFunc == null)
            {
               _GuiPopUpMenuCtrlSetTextFunc =
                  (_GuiPopUpMenuCtrlSetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlSetText"), typeof(_GuiPopUpMenuCtrlSetText));
            }

            _GuiPopUpMenuCtrlSetTextFunc(ctrl, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiPopUpMenuCtrlGetText(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlGetText _GuiPopUpMenuCtrlGetTextFunc;
         internal static IntPtr GuiPopUpMenuCtrlGetText(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlGetTextFunc == null)
            {
               _GuiPopUpMenuCtrlGetTextFunc =
                  (_GuiPopUpMenuCtrlGetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlGetText"), typeof(_GuiPopUpMenuCtrlGetText));
            }

            return _GuiPopUpMenuCtrlGetTextFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlClear(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlClear _GuiPopUpMenuCtrlClearFunc;
         internal static void GuiPopUpMenuCtrlClear(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlClearFunc == null)
            {
               _GuiPopUpMenuCtrlClearFunc =
                  (_GuiPopUpMenuCtrlClear)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlClear"), typeof(_GuiPopUpMenuCtrlClear));
            }

            _GuiPopUpMenuCtrlClearFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlSort(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlSort _GuiPopUpMenuCtrlSortFunc;
         internal static void GuiPopUpMenuCtrlSort(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlSortFunc == null)
            {
               _GuiPopUpMenuCtrlSortFunc =
                  (_GuiPopUpMenuCtrlSort)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlSort"), typeof(_GuiPopUpMenuCtrlSort));
            }

            _GuiPopUpMenuCtrlSortFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlSortID(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlSortID _GuiPopUpMenuCtrlSortIDFunc;
         internal static void GuiPopUpMenuCtrlSortID(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlSortIDFunc == null)
            {
               _GuiPopUpMenuCtrlSortIDFunc =
                  (_GuiPopUpMenuCtrlSortID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlSortID"), typeof(_GuiPopUpMenuCtrlSortID));
            }

            _GuiPopUpMenuCtrlSortIDFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlForceOnAction(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlForceOnAction _GuiPopUpMenuCtrlForceOnActionFunc;
         internal static void GuiPopUpMenuCtrlForceOnAction(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlForceOnActionFunc == null)
            {
               _GuiPopUpMenuCtrlForceOnActionFunc =
                  (_GuiPopUpMenuCtrlForceOnAction)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlForceOnAction"), typeof(_GuiPopUpMenuCtrlForceOnAction));
            }

            _GuiPopUpMenuCtrlForceOnActionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlClosePopUp(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlClosePopUp _GuiPopUpMenuCtrlClosePopUpFunc;
         internal static void GuiPopUpMenuCtrlClosePopUp(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlClosePopUpFunc == null)
            {
               _GuiPopUpMenuCtrlClosePopUpFunc =
                  (_GuiPopUpMenuCtrlClosePopUp)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlClosePopUp"), typeof(_GuiPopUpMenuCtrlClosePopUp));
            }

            _GuiPopUpMenuCtrlClosePopUpFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiPopUpMenuCtrlGetSelected(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlGetSelected _GuiPopUpMenuCtrlGetSelectedFunc;
         internal static int GuiPopUpMenuCtrlGetSelected(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlGetSelectedFunc == null)
            {
               _GuiPopUpMenuCtrlGetSelectedFunc =
                  (_GuiPopUpMenuCtrlGetSelected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlGetSelected"), typeof(_GuiPopUpMenuCtrlGetSelected));
            }

            return _GuiPopUpMenuCtrlGetSelectedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlSetSelected(IntPtr ctrl, int id, bool scriptCallback);
         private static _GuiPopUpMenuCtrlSetSelected _GuiPopUpMenuCtrlSetSelectedFunc;
         internal static void GuiPopUpMenuCtrlSetSelected(IntPtr ctrl, int id, bool scriptCallback)
         {
            if (_GuiPopUpMenuCtrlSetSelectedFunc == null)
            {
               _GuiPopUpMenuCtrlSetSelectedFunc =
                  (_GuiPopUpMenuCtrlSetSelected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlSetSelected"), typeof(_GuiPopUpMenuCtrlSetSelected));
            }

            _GuiPopUpMenuCtrlSetSelectedFunc(ctrl, id, scriptCallback);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlSetFirstSelected(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlSetFirstSelected _GuiPopUpMenuCtrlSetFirstSelectedFunc;
         internal static void GuiPopUpMenuCtrlSetFirstSelected(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlSetFirstSelectedFunc == null)
            {
               _GuiPopUpMenuCtrlSetFirstSelectedFunc =
                  (_GuiPopUpMenuCtrlSetFirstSelected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlSetFirstSelected"), typeof(_GuiPopUpMenuCtrlSetFirstSelected));
            }

            _GuiPopUpMenuCtrlSetFirstSelectedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlSetNoneSelected(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlSetNoneSelected _GuiPopUpMenuCtrlSetNoneSelectedFunc;
         internal static void GuiPopUpMenuCtrlSetNoneSelected(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlSetNoneSelectedFunc == null)
            {
               _GuiPopUpMenuCtrlSetNoneSelectedFunc =
                  (_GuiPopUpMenuCtrlSetNoneSelected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlSetNoneSelected"), typeof(_GuiPopUpMenuCtrlSetNoneSelected));
            }

            _GuiPopUpMenuCtrlSetNoneSelectedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiPopUpMenuCtrlGetTextById(IntPtr ctrl, int ID);
         private static _GuiPopUpMenuCtrlGetTextById _GuiPopUpMenuCtrlGetTextByIdFunc;
         internal static IntPtr GuiPopUpMenuCtrlGetTextById(IntPtr ctrl, int ID)
         {
            if (_GuiPopUpMenuCtrlGetTextByIdFunc == null)
            {
               _GuiPopUpMenuCtrlGetTextByIdFunc =
                  (_GuiPopUpMenuCtrlGetTextById)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlGetTextById"), typeof(_GuiPopUpMenuCtrlGetTextById));
            }

            return _GuiPopUpMenuCtrlGetTextByIdFunc(ctrl, ID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlSetEnumContent(IntPtr ctrl, string contentClass, string contentEnum);
         private static _GuiPopUpMenuCtrlSetEnumContent _GuiPopUpMenuCtrlSetEnumContentFunc;
         internal static void GuiPopUpMenuCtrlSetEnumContent(IntPtr ctrl, string contentClass, string contentEnum)
         {
            if (_GuiPopUpMenuCtrlSetEnumContentFunc == null)
            {
               _GuiPopUpMenuCtrlSetEnumContentFunc =
                  (_GuiPopUpMenuCtrlSetEnumContent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlSetEnumContent"), typeof(_GuiPopUpMenuCtrlSetEnumContent));
            }

            _GuiPopUpMenuCtrlSetEnumContentFunc(ctrl, contentClass, contentEnum);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiPopUpMenuCtrlFindText(IntPtr ctrl, string text);
         private static _GuiPopUpMenuCtrlFindText _GuiPopUpMenuCtrlFindTextFunc;
         internal static int GuiPopUpMenuCtrlFindText(IntPtr ctrl, string text)
         {
            if (_GuiPopUpMenuCtrlFindTextFunc == null)
            {
               _GuiPopUpMenuCtrlFindTextFunc =
                  (_GuiPopUpMenuCtrlFindText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlFindText"), typeof(_GuiPopUpMenuCtrlFindText));
            }

            return _GuiPopUpMenuCtrlFindTextFunc(ctrl, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiPopUpMenuCtrlSize(IntPtr ctrl);
         private static _GuiPopUpMenuCtrlSize _GuiPopUpMenuCtrlSizeFunc;
         internal static int GuiPopUpMenuCtrlSize(IntPtr ctrl)
         {
            if (_GuiPopUpMenuCtrlSizeFunc == null)
            {
               _GuiPopUpMenuCtrlSizeFunc =
                  (_GuiPopUpMenuCtrlSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlSize"), typeof(_GuiPopUpMenuCtrlSize));
            }

            return _GuiPopUpMenuCtrlSizeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPopUpMenuCtrlReplaceText(IntPtr ctrl, bool enable);
         private static _GuiPopUpMenuCtrlReplaceText _GuiPopUpMenuCtrlReplaceTextFunc;
         internal static void GuiPopUpMenuCtrlReplaceText(IntPtr ctrl, bool enable)
         {
            if (_GuiPopUpMenuCtrlReplaceTextFunc == null)
            {
               _GuiPopUpMenuCtrlReplaceTextFunc =
                  (_GuiPopUpMenuCtrlReplaceText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPopUpMenuCtrlReplaceText"), typeof(_GuiPopUpMenuCtrlReplaceText));
            }

            _GuiPopUpMenuCtrlReplaceTextFunc(ctrl, enable);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void Add(string entryText, int entryID, int entryScheme)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlAdd(ObjectPtr->ObjPtr, entryText, entryID, entryScheme);
      }

      public void AddScheme(int entryScheme, Color fontColor, Color fontColorHL, Color fontColorSEL)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlAddScheme(ObjectPtr->ObjPtr, entryScheme, fontColor, fontColorHL, fontColorSEL);
      }

      public void SetText(string text)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlSetText(ObjectPtr->ObjPtr, text);
      }

      public string GetText()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiPopUpMenuCtrlGetText(ObjectPtr->ObjPtr));
      }

      public void Clear()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlClear(ObjectPtr->ObjPtr);
      }

      public void Sort()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlSort(ObjectPtr->ObjPtr);
      }

      public void SortID()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlSortID(ObjectPtr->ObjPtr);
      }

      public void ForceOnAction()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlForceOnAction(ObjectPtr->ObjPtr);
      }

      public void ClosePopUp()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlClosePopUp(ObjectPtr->ObjPtr);
      }

      public int GetSelected()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiPopUpMenuCtrlGetSelected(ObjectPtr->ObjPtr);
      }

      public void SetSelected(int id, bool scriptCallback)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlSetSelected(ObjectPtr->ObjPtr, id, scriptCallback);
      }

      public void SetFirstSelected()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlSetFirstSelected(ObjectPtr->ObjPtr);
      }

      public void SetNoneSelected()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlSetNoneSelected(ObjectPtr->ObjPtr);
      }

      public string GetTextById(int ID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiPopUpMenuCtrlGetTextById(ObjectPtr->ObjPtr, ID));
      }

      public void SetEnumContent(string contentClass, string contentEnum)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlSetEnumContent(ObjectPtr->ObjPtr, contentClass, contentEnum);
      }

      public int FindText(string text)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiPopUpMenuCtrlFindText(ObjectPtr->ObjPtr, text);
      }

      public int Size()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiPopUpMenuCtrlSize(ObjectPtr->ObjPtr);
      }

      public void ReplaceText(bool enable)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPopUpMenuCtrlReplaceText(ObjectPtr->ObjPtr, enable);
      }
      
      #endregion

      
   }
}