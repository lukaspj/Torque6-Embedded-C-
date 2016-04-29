using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiListBoxCtrl : GuiControl
   {
      
      public GuiListBoxCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiListBoxCtrlCreateInstance());
      }

      public GuiListBoxCtrl(uint pId) : base(pId)
      {
      }

      public GuiListBoxCtrl(string pName) : base(pName)
      {
      }

      public GuiListBoxCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiListBoxCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiListBoxCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiListBoxCtrlGetAllowMultipleSelections(IntPtr ctrl);
         private static _GuiListBoxCtrlGetAllowMultipleSelections _GuiListBoxCtrlGetAllowMultipleSelectionsFunc;
         internal static bool GuiListBoxCtrlGetAllowMultipleSelections(IntPtr ctrl)
         {
            if (_GuiListBoxCtrlGetAllowMultipleSelectionsFunc == null)
            {
               _GuiListBoxCtrlGetAllowMultipleSelectionsFunc =
                  (_GuiListBoxCtrlGetAllowMultipleSelections)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlGetAllowMultipleSelections"), typeof(_GuiListBoxCtrlGetAllowMultipleSelections));
            }

            return _GuiListBoxCtrlGetAllowMultipleSelectionsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlSetAllowMultipleSelections(IntPtr ctrl, bool allow);
         private static _GuiListBoxCtrlSetAllowMultipleSelections _GuiListBoxCtrlSetAllowMultipleSelectionsFunc;
         internal static void GuiListBoxCtrlSetAllowMultipleSelections(IntPtr ctrl, bool allow)
         {
            if (_GuiListBoxCtrlSetAllowMultipleSelectionsFunc == null)
            {
               _GuiListBoxCtrlSetAllowMultipleSelectionsFunc =
                  (_GuiListBoxCtrlSetAllowMultipleSelections)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlSetAllowMultipleSelections"), typeof(_GuiListBoxCtrlSetAllowMultipleSelections));
            }

            _GuiListBoxCtrlSetAllowMultipleSelectionsFunc(ctrl, allow);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiListBoxCtrlGetFitParentWidth(IntPtr ctrl);
         private static _GuiListBoxCtrlGetFitParentWidth _GuiListBoxCtrlGetFitParentWidthFunc;
         internal static bool GuiListBoxCtrlGetFitParentWidth(IntPtr ctrl)
         {
            if (_GuiListBoxCtrlGetFitParentWidthFunc == null)
            {
               _GuiListBoxCtrlGetFitParentWidthFunc =
                  (_GuiListBoxCtrlGetFitParentWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlGetFitParentWidth"), typeof(_GuiListBoxCtrlGetFitParentWidth));
            }

            return _GuiListBoxCtrlGetFitParentWidthFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlSetFitParentWidth(IntPtr ctrl, bool fit);
         private static _GuiListBoxCtrlSetFitParentWidth _GuiListBoxCtrlSetFitParentWidthFunc;
         internal static void GuiListBoxCtrlSetFitParentWidth(IntPtr ctrl, bool fit)
         {
            if (_GuiListBoxCtrlSetFitParentWidthFunc == null)
            {
               _GuiListBoxCtrlSetFitParentWidthFunc =
                  (_GuiListBoxCtrlSetFitParentWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlSetFitParentWidth"), typeof(_GuiListBoxCtrlSetFitParentWidth));
            }

            _GuiListBoxCtrlSetFitParentWidthFunc(ctrl, fit);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiListBoxCtrlCreateInstance();
         private static _GuiListBoxCtrlCreateInstance _GuiListBoxCtrlCreateInstanceFunc;
         internal static IntPtr GuiListBoxCtrlCreateInstance()
         {
            if (_GuiListBoxCtrlCreateInstanceFunc == null)
            {
               _GuiListBoxCtrlCreateInstanceFunc =
                  (_GuiListBoxCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlCreateInstance"), typeof(_GuiListBoxCtrlCreateInstance));
            }

            return _GuiListBoxCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlSetMultipleSelection(IntPtr ctrl, bool enable);
         private static _GuiListBoxCtrlSetMultipleSelection _GuiListBoxCtrlSetMultipleSelectionFunc;
         internal static void GuiListBoxCtrlSetMultipleSelection(IntPtr ctrl, bool enable)
         {
            if (_GuiListBoxCtrlSetMultipleSelectionFunc == null)
            {
               _GuiListBoxCtrlSetMultipleSelectionFunc =
                  (_GuiListBoxCtrlSetMultipleSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlSetMultipleSelection"), typeof(_GuiListBoxCtrlSetMultipleSelection));
            }

            _GuiListBoxCtrlSetMultipleSelectionFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlClearItems(IntPtr ctrl);
         private static _GuiListBoxCtrlClearItems _GuiListBoxCtrlClearItemsFunc;
         internal static void GuiListBoxCtrlClearItems(IntPtr ctrl)
         {
            if (_GuiListBoxCtrlClearItemsFunc == null)
            {
               _GuiListBoxCtrlClearItemsFunc =
                  (_GuiListBoxCtrlClearItems)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlClearItems"), typeof(_GuiListBoxCtrlClearItems));
            }

            _GuiListBoxCtrlClearItemsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlClearSelection(IntPtr ctrl);
         private static _GuiListBoxCtrlClearSelection _GuiListBoxCtrlClearSelectionFunc;
         internal static void GuiListBoxCtrlClearSelection(IntPtr ctrl)
         {
            if (_GuiListBoxCtrlClearSelectionFunc == null)
            {
               _GuiListBoxCtrlClearSelectionFunc =
                  (_GuiListBoxCtrlClearSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlClearSelection"), typeof(_GuiListBoxCtrlClearSelection));
            }

            _GuiListBoxCtrlClearSelectionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlSetSelected(IntPtr ctrl, int index, bool setting);
         private static _GuiListBoxCtrlSetSelected _GuiListBoxCtrlSetSelectedFunc;
         internal static void GuiListBoxCtrlSetSelected(IntPtr ctrl, int index, bool setting)
         {
            if (_GuiListBoxCtrlSetSelectedFunc == null)
            {
               _GuiListBoxCtrlSetSelectedFunc =
                  (_GuiListBoxCtrlSetSelected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlSetSelected"), typeof(_GuiListBoxCtrlSetSelected));
            }

            _GuiListBoxCtrlSetSelectedFunc(ctrl, index, setting);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiListBoxCtrlGetItemCount(IntPtr ctrl);
         private static _GuiListBoxCtrlGetItemCount _GuiListBoxCtrlGetItemCountFunc;
         internal static int GuiListBoxCtrlGetItemCount(IntPtr ctrl)
         {
            if (_GuiListBoxCtrlGetItemCountFunc == null)
            {
               _GuiListBoxCtrlGetItemCountFunc =
                  (_GuiListBoxCtrlGetItemCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlGetItemCount"), typeof(_GuiListBoxCtrlGetItemCount));
            }

            return _GuiListBoxCtrlGetItemCountFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiListBoxCtrlGetSelCount(IntPtr ctrl);
         private static _GuiListBoxCtrlGetSelCount _GuiListBoxCtrlGetSelCountFunc;
         internal static int GuiListBoxCtrlGetSelCount(IntPtr ctrl)
         {
            if (_GuiListBoxCtrlGetSelCountFunc == null)
            {
               _GuiListBoxCtrlGetSelCountFunc =
                  (_GuiListBoxCtrlGetSelCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlGetSelCount"), typeof(_GuiListBoxCtrlGetSelCount));
            }

            return _GuiListBoxCtrlGetSelCountFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiListBoxCtrlGetSelectedItem(IntPtr ctrl);
         private static _GuiListBoxCtrlGetSelectedItem _GuiListBoxCtrlGetSelectedItemFunc;
         internal static int GuiListBoxCtrlGetSelectedItem(IntPtr ctrl)
         {
            if (_GuiListBoxCtrlGetSelectedItemFunc == null)
            {
               _GuiListBoxCtrlGetSelectedItemFunc =
                  (_GuiListBoxCtrlGetSelectedItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlGetSelectedItem"), typeof(_GuiListBoxCtrlGetSelectedItem));
            }

            return _GuiListBoxCtrlGetSelectedItemFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _GuiListBoxCtrlGetSelectedItems(IntPtr ctrl);
         private static _GuiListBoxCtrlGetSelectedItems _GuiListBoxCtrlGetSelectedItemsFunc;
         internal static int[] GuiListBoxCtrlGetSelectedItems(IntPtr ctrl)
         {
            if (_GuiListBoxCtrlGetSelectedItemsFunc == null)
            {
               _GuiListBoxCtrlGetSelectedItemsFunc =
                  (_GuiListBoxCtrlGetSelectedItems)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlGetSelectedItems"), typeof(_GuiListBoxCtrlGetSelectedItems));
            }

            return _GuiListBoxCtrlGetSelectedItemsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiListBoxCtrlFindItemText(IntPtr ctrl, string itemText, bool caseSensitive);
         private static _GuiListBoxCtrlFindItemText _GuiListBoxCtrlFindItemTextFunc;
         internal static int GuiListBoxCtrlFindItemText(IntPtr ctrl, string itemText, bool caseSensitive)
         {
            if (_GuiListBoxCtrlFindItemTextFunc == null)
            {
               _GuiListBoxCtrlFindItemTextFunc =
                  (_GuiListBoxCtrlFindItemText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlFindItemText"), typeof(_GuiListBoxCtrlFindItemText));
            }

            return _GuiListBoxCtrlFindItemTextFunc(ctrl, itemText, caseSensitive);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlSetCurSel(IntPtr ctrl, int index);
         private static _GuiListBoxCtrlSetCurSel _GuiListBoxCtrlSetCurSelFunc;
         internal static void GuiListBoxCtrlSetCurSel(IntPtr ctrl, int index)
         {
            if (_GuiListBoxCtrlSetCurSelFunc == null)
            {
               _GuiListBoxCtrlSetCurSelFunc =
                  (_GuiListBoxCtrlSetCurSel)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlSetCurSel"), typeof(_GuiListBoxCtrlSetCurSel));
            }

            _GuiListBoxCtrlSetCurSelFunc(ctrl, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlSetCurSelRange(IntPtr ctrl, int start, int stop);
         private static _GuiListBoxCtrlSetCurSelRange _GuiListBoxCtrlSetCurSelRangeFunc;
         internal static void GuiListBoxCtrlSetCurSelRange(IntPtr ctrl, int start, int stop)
         {
            if (_GuiListBoxCtrlSetCurSelRangeFunc == null)
            {
               _GuiListBoxCtrlSetCurSelRangeFunc =
                  (_GuiListBoxCtrlSetCurSelRange)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlSetCurSelRange"), typeof(_GuiListBoxCtrlSetCurSelRange));
            }

            _GuiListBoxCtrlSetCurSelRangeFunc(ctrl, start, stop);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlAddItem(IntPtr ctrl, string text, Color color);
         private static _GuiListBoxCtrlAddItem _GuiListBoxCtrlAddItemFunc;
         internal static void GuiListBoxCtrlAddItem(IntPtr ctrl, string text, Color color)
         {
            if (_GuiListBoxCtrlAddItemFunc == null)
            {
               _GuiListBoxCtrlAddItemFunc =
                  (_GuiListBoxCtrlAddItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlAddItem"), typeof(_GuiListBoxCtrlAddItem));
            }

            _GuiListBoxCtrlAddItemFunc(ctrl, text, color);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlSetItemColor(IntPtr ctrl, int index, Color color);
         private static _GuiListBoxCtrlSetItemColor _GuiListBoxCtrlSetItemColorFunc;
         internal static void GuiListBoxCtrlSetItemColor(IntPtr ctrl, int index, Color color)
         {
            if (_GuiListBoxCtrlSetItemColorFunc == null)
            {
               _GuiListBoxCtrlSetItemColorFunc =
                  (_GuiListBoxCtrlSetItemColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlSetItemColor"), typeof(_GuiListBoxCtrlSetItemColor));
            }

            _GuiListBoxCtrlSetItemColorFunc(ctrl, index, color);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlClearItemColor(IntPtr ctrl, int index);
         private static _GuiListBoxCtrlClearItemColor _GuiListBoxCtrlClearItemColorFunc;
         internal static void GuiListBoxCtrlClearItemColor(IntPtr ctrl, int index)
         {
            if (_GuiListBoxCtrlClearItemColorFunc == null)
            {
               _GuiListBoxCtrlClearItemColorFunc =
                  (_GuiListBoxCtrlClearItemColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlClearItemColor"), typeof(_GuiListBoxCtrlClearItemColor));
            }

            _GuiListBoxCtrlClearItemColorFunc(ctrl, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlInsertItem(IntPtr ctrl, string text, int index);
         private static _GuiListBoxCtrlInsertItem _GuiListBoxCtrlInsertItemFunc;
         internal static void GuiListBoxCtrlInsertItem(IntPtr ctrl, string text, int index)
         {
            if (_GuiListBoxCtrlInsertItemFunc == null)
            {
               _GuiListBoxCtrlInsertItemFunc =
                  (_GuiListBoxCtrlInsertItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlInsertItem"), typeof(_GuiListBoxCtrlInsertItem));
            }

            _GuiListBoxCtrlInsertItemFunc(ctrl, text, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlDeleteItem(IntPtr ctrl, int index);
         private static _GuiListBoxCtrlDeleteItem _GuiListBoxCtrlDeleteItemFunc;
         internal static void GuiListBoxCtrlDeleteItem(IntPtr ctrl, int index)
         {
            if (_GuiListBoxCtrlDeleteItemFunc == null)
            {
               _GuiListBoxCtrlDeleteItemFunc =
                  (_GuiListBoxCtrlDeleteItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlDeleteItem"), typeof(_GuiListBoxCtrlDeleteItem));
            }

            _GuiListBoxCtrlDeleteItemFunc(ctrl, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiListBoxCtrlSetItemtext(IntPtr ctrl, int index, string newText);
         private static _GuiListBoxCtrlSetItemtext _GuiListBoxCtrlSetItemtextFunc;
         internal static void GuiListBoxCtrlSetItemtext(IntPtr ctrl, int index, string newText)
         {
            if (_GuiListBoxCtrlSetItemtextFunc == null)
            {
               _GuiListBoxCtrlSetItemtextFunc =
                  (_GuiListBoxCtrlSetItemtext)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlSetItemtext"), typeof(_GuiListBoxCtrlSetItemtext));
            }

            _GuiListBoxCtrlSetItemtextFunc(ctrl, index, newText);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiListBoxCtrlGetItemtext(IntPtr ctrl, int index);
         private static _GuiListBoxCtrlGetItemtext _GuiListBoxCtrlGetItemtextFunc;
         internal static IntPtr GuiListBoxCtrlGetItemtext(IntPtr ctrl, int index)
         {
            if (_GuiListBoxCtrlGetItemtextFunc == null)
            {
               _GuiListBoxCtrlGetItemtextFunc =
                  (_GuiListBoxCtrlGetItemtext)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiListBoxCtrlGetItemtext"), typeof(_GuiListBoxCtrlGetItemtext));
            }

            return _GuiListBoxCtrlGetItemtextFunc(ctrl, index);
         }
      }
      
      #endregion

      #region Properties

      public bool AllowMultipleSelections
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiListBoxCtrlGetAllowMultipleSelections(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiListBoxCtrlSetAllowMultipleSelections(ObjectPtr->ObjPtr, value);
         }
      }
      public bool FitParentWidth
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiListBoxCtrlGetFitParentWidth(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiListBoxCtrlSetFitParentWidth(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void SetMultipleSelection(bool enable)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlSetMultipleSelection(ObjectPtr->ObjPtr, enable);
      }

      public void ClearItems()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlClearItems(ObjectPtr->ObjPtr);
      }

      public void ClearSelection()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlClearSelection(ObjectPtr->ObjPtr);
      }

      public void SetSelected(int index, bool setting)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlSetSelected(ObjectPtr->ObjPtr, index, setting);
      }

      public int GetItemCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiListBoxCtrlGetItemCount(ObjectPtr->ObjPtr);
      }

      public int GetSelCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiListBoxCtrlGetSelCount(ObjectPtr->ObjPtr);
      }

      public int GetSelectedItem()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiListBoxCtrlGetSelectedItem(ObjectPtr->ObjPtr);
      }

      public int[] GetSelectedItems()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiListBoxCtrlGetSelectedItems(ObjectPtr->ObjPtr);
      }

      public int FindItemText(string itemText, bool caseSensitive)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiListBoxCtrlFindItemText(ObjectPtr->ObjPtr, itemText, caseSensitive);
      }

      public void SetCurSel(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlSetCurSel(ObjectPtr->ObjPtr, index);
      }

      public void SetCurSelRange(int start, int stop)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlSetCurSelRange(ObjectPtr->ObjPtr, start, stop);
      }

      public void AddItem(string text, Color color)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlAddItem(ObjectPtr->ObjPtr, text, color);
      }

      public void SetItemColor(int index, Color color)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlSetItemColor(ObjectPtr->ObjPtr, index, color);
      }

      public void ClearItemColor(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlClearItemColor(ObjectPtr->ObjPtr, index);
      }

      public void InsertItem(string text, int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlInsertItem(ObjectPtr->ObjPtr, text, index);
      }

      public void DeleteItem(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlDeleteItem(ObjectPtr->ObjPtr, index);
      }

      public void SetItemtext(int index, string newText)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiListBoxCtrlSetItemtext(ObjectPtr->ObjPtr, index, newText);
      }

      public string GetItemtext(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiListBoxCtrlGetItemtext(ObjectPtr->ObjPtr, index));
      }
      
      #endregion

      
   }
}