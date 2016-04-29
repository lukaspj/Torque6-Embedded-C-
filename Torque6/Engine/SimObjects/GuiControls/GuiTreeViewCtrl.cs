using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiTreeViewCtrl : GuiArrayCtrl
   {
      
      public GuiTreeViewCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiTreeViewCtrlCreateInstance());
      }

      public GuiTreeViewCtrl(uint pId) : base(pId)
      {
      }

      public GuiTreeViewCtrl(string pName) : base(pName)
      {
      }

      public GuiTreeViewCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTreeViewCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTreeViewCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetTabSize(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetTabSize _GuiTreeViewCtrlGetTabSizeFunc;
         internal static int GuiTreeViewCtrlGetTabSize(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetTabSizeFunc == null)
            {
               _GuiTreeViewCtrlGetTabSizeFunc =
                  (_GuiTreeViewCtrlGetTabSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetTabSize"), typeof(_GuiTreeViewCtrlGetTabSize));
            }

            return _GuiTreeViewCtrlGetTabSizeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlSetTabSize(IntPtr ctrl, int size);
         private static _GuiTreeViewCtrlSetTabSize _GuiTreeViewCtrlSetTabSizeFunc;
         internal static void GuiTreeViewCtrlSetTabSize(IntPtr ctrl, int size)
         {
            if (_GuiTreeViewCtrlSetTabSizeFunc == null)
            {
               _GuiTreeViewCtrlSetTabSizeFunc =
                  (_GuiTreeViewCtrlSetTabSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSetTabSize"), typeof(_GuiTreeViewCtrlSetTabSize));
            }

            _GuiTreeViewCtrlSetTabSizeFunc(ctrl, size);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetTextOffset(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetTextOffset _GuiTreeViewCtrlGetTextOffsetFunc;
         internal static int GuiTreeViewCtrlGetTextOffset(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetTextOffsetFunc == null)
            {
               _GuiTreeViewCtrlGetTextOffsetFunc =
                  (_GuiTreeViewCtrlGetTextOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetTextOffset"), typeof(_GuiTreeViewCtrlGetTextOffset));
            }

            return _GuiTreeViewCtrlGetTextOffsetFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlSetTextOffset(IntPtr ctrl, int offset);
         private static _GuiTreeViewCtrlSetTextOffset _GuiTreeViewCtrlSetTextOffsetFunc;
         internal static void GuiTreeViewCtrlSetTextOffset(IntPtr ctrl, int offset)
         {
            if (_GuiTreeViewCtrlSetTextOffsetFunc == null)
            {
               _GuiTreeViewCtrlSetTextOffsetFunc =
                  (_GuiTreeViewCtrlSetTextOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSetTextOffset"), typeof(_GuiTreeViewCtrlSetTextOffset));
            }

            _GuiTreeViewCtrlSetTextOffsetFunc(ctrl, offset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlGetFullRowSelect(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetFullRowSelect _GuiTreeViewCtrlGetFullRowSelectFunc;
         internal static bool GuiTreeViewCtrlGetFullRowSelect(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetFullRowSelectFunc == null)
            {
               _GuiTreeViewCtrlGetFullRowSelectFunc =
                  (_GuiTreeViewCtrlGetFullRowSelect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetFullRowSelect"), typeof(_GuiTreeViewCtrlGetFullRowSelect));
            }

            return _GuiTreeViewCtrlGetFullRowSelectFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlSetFullRowSelect(IntPtr ctrl, bool fullRowSelect);
         private static _GuiTreeViewCtrlSetFullRowSelect _GuiTreeViewCtrlSetFullRowSelectFunc;
         internal static void GuiTreeViewCtrlSetFullRowSelect(IntPtr ctrl, bool fullRowSelect)
         {
            if (_GuiTreeViewCtrlSetFullRowSelectFunc == null)
            {
               _GuiTreeViewCtrlSetFullRowSelectFunc =
                  (_GuiTreeViewCtrlSetFullRowSelect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSetFullRowSelect"), typeof(_GuiTreeViewCtrlSetFullRowSelect));
            }

            _GuiTreeViewCtrlSetFullRowSelectFunc(ctrl, fullRowSelect);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetItemHeight(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetItemHeight _GuiTreeViewCtrlGetItemHeightFunc;
         internal static int GuiTreeViewCtrlGetItemHeight(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetItemHeightFunc == null)
            {
               _GuiTreeViewCtrlGetItemHeightFunc =
                  (_GuiTreeViewCtrlGetItemHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetItemHeight"), typeof(_GuiTreeViewCtrlGetItemHeight));
            }

            return _GuiTreeViewCtrlGetItemHeightFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlSetItemHeight(IntPtr ctrl, int height);
         private static _GuiTreeViewCtrlSetItemHeight _GuiTreeViewCtrlSetItemHeightFunc;
         internal static void GuiTreeViewCtrlSetItemHeight(IntPtr ctrl, int height)
         {
            if (_GuiTreeViewCtrlSetItemHeightFunc == null)
            {
               _GuiTreeViewCtrlSetItemHeightFunc =
                  (_GuiTreeViewCtrlSetItemHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSetItemHeight"), typeof(_GuiTreeViewCtrlSetItemHeight));
            }

            _GuiTreeViewCtrlSetItemHeightFunc(ctrl, height);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlGetDestroyTreeOnSleep(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetDestroyTreeOnSleep _GuiTreeViewCtrlGetDestroyTreeOnSleepFunc;
         internal static bool GuiTreeViewCtrlGetDestroyTreeOnSleep(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetDestroyTreeOnSleepFunc == null)
            {
               _GuiTreeViewCtrlGetDestroyTreeOnSleepFunc =
                  (_GuiTreeViewCtrlGetDestroyTreeOnSleep)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetDestroyTreeOnSleep"), typeof(_GuiTreeViewCtrlGetDestroyTreeOnSleep));
            }

            return _GuiTreeViewCtrlGetDestroyTreeOnSleepFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlSetDestroyTreeOnSleep(IntPtr ctrl, bool destroyOnSleep);
         private static _GuiTreeViewCtrlSetDestroyTreeOnSleep _GuiTreeViewCtrlSetDestroyTreeOnSleepFunc;
         internal static void GuiTreeViewCtrlSetDestroyTreeOnSleep(IntPtr ctrl, bool destroyOnSleep)
         {
            if (_GuiTreeViewCtrlSetDestroyTreeOnSleepFunc == null)
            {
               _GuiTreeViewCtrlSetDestroyTreeOnSleepFunc =
                  (_GuiTreeViewCtrlSetDestroyTreeOnSleep)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSetDestroyTreeOnSleep"), typeof(_GuiTreeViewCtrlSetDestroyTreeOnSleep));
            }

            _GuiTreeViewCtrlSetDestroyTreeOnSleepFunc(ctrl, destroyOnSleep);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlGetMouseDragging(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetMouseDragging _GuiTreeViewCtrlGetMouseDraggingFunc;
         internal static bool GuiTreeViewCtrlGetMouseDragging(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetMouseDraggingFunc == null)
            {
               _GuiTreeViewCtrlGetMouseDraggingFunc =
                  (_GuiTreeViewCtrlGetMouseDragging)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetMouseDragging"), typeof(_GuiTreeViewCtrlGetMouseDragging));
            }

            return _GuiTreeViewCtrlGetMouseDraggingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlSetMouseDragging(IntPtr ctrl, bool allowDragging);
         private static _GuiTreeViewCtrlSetMouseDragging _GuiTreeViewCtrlSetMouseDraggingFunc;
         internal static void GuiTreeViewCtrlSetMouseDragging(IntPtr ctrl, bool allowDragging)
         {
            if (_GuiTreeViewCtrlSetMouseDraggingFunc == null)
            {
               _GuiTreeViewCtrlSetMouseDraggingFunc =
                  (_GuiTreeViewCtrlSetMouseDragging)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSetMouseDragging"), typeof(_GuiTreeViewCtrlSetMouseDragging));
            }

            _GuiTreeViewCtrlSetMouseDraggingFunc(ctrl, allowDragging);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlGetMultipleSelections(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetMultipleSelections _GuiTreeViewCtrlGetMultipleSelectionsFunc;
         internal static bool GuiTreeViewCtrlGetMultipleSelections(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetMultipleSelectionsFunc == null)
            {
               _GuiTreeViewCtrlGetMultipleSelectionsFunc =
                  (_GuiTreeViewCtrlGetMultipleSelections)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetMultipleSelections"), typeof(_GuiTreeViewCtrlGetMultipleSelections));
            }

            return _GuiTreeViewCtrlGetMultipleSelectionsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlSetMultipleSelections(IntPtr ctrl, bool multipleSelections);
         private static _GuiTreeViewCtrlSetMultipleSelections _GuiTreeViewCtrlSetMultipleSelectionsFunc;
         internal static void GuiTreeViewCtrlSetMultipleSelections(IntPtr ctrl, bool multipleSelections)
         {
            if (_GuiTreeViewCtrlSetMultipleSelectionsFunc == null)
            {
               _GuiTreeViewCtrlSetMultipleSelectionsFunc =
                  (_GuiTreeViewCtrlSetMultipleSelections)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSetMultipleSelections"), typeof(_GuiTreeViewCtrlSetMultipleSelections));
            }

            _GuiTreeViewCtrlSetMultipleSelectionsFunc(ctrl, multipleSelections);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlGetDeleteObjectAllowed(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetDeleteObjectAllowed _GuiTreeViewCtrlGetDeleteObjectAllowedFunc;
         internal static bool GuiTreeViewCtrlGetDeleteObjectAllowed(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetDeleteObjectAllowedFunc == null)
            {
               _GuiTreeViewCtrlGetDeleteObjectAllowedFunc =
                  (_GuiTreeViewCtrlGetDeleteObjectAllowed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetDeleteObjectAllowed"), typeof(_GuiTreeViewCtrlGetDeleteObjectAllowed));
            }

            return _GuiTreeViewCtrlGetDeleteObjectAllowedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlSetDeleteObjectAllowed(IntPtr ctrl, bool allowDelete);
         private static _GuiTreeViewCtrlSetDeleteObjectAllowed _GuiTreeViewCtrlSetDeleteObjectAllowedFunc;
         internal static void GuiTreeViewCtrlSetDeleteObjectAllowed(IntPtr ctrl, bool allowDelete)
         {
            if (_GuiTreeViewCtrlSetDeleteObjectAllowedFunc == null)
            {
               _GuiTreeViewCtrlSetDeleteObjectAllowedFunc =
                  (_GuiTreeViewCtrlSetDeleteObjectAllowed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSetDeleteObjectAllowed"), typeof(_GuiTreeViewCtrlSetDeleteObjectAllowed));
            }

            _GuiTreeViewCtrlSetDeleteObjectAllowedFunc(ctrl, allowDelete);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlGetDragToItemAllowed(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetDragToItemAllowed _GuiTreeViewCtrlGetDragToItemAllowedFunc;
         internal static bool GuiTreeViewCtrlGetDragToItemAllowed(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetDragToItemAllowedFunc == null)
            {
               _GuiTreeViewCtrlGetDragToItemAllowedFunc =
                  (_GuiTreeViewCtrlGetDragToItemAllowed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetDragToItemAllowed"), typeof(_GuiTreeViewCtrlGetDragToItemAllowed));
            }

            return _GuiTreeViewCtrlGetDragToItemAllowedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlSetDragToItemAllowed(IntPtr ctrl, bool allowDrag);
         private static _GuiTreeViewCtrlSetDragToItemAllowed _GuiTreeViewCtrlSetDragToItemAllowedFunc;
         internal static void GuiTreeViewCtrlSetDragToItemAllowed(IntPtr ctrl, bool allowDrag)
         {
            if (_GuiTreeViewCtrlSetDragToItemAllowedFunc == null)
            {
               _GuiTreeViewCtrlSetDragToItemAllowedFunc =
                  (_GuiTreeViewCtrlSetDragToItemAllowed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSetDragToItemAllowed"), typeof(_GuiTreeViewCtrlSetDragToItemAllowed));
            }

            _GuiTreeViewCtrlSetDragToItemAllowedFunc(ctrl, allowDrag);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTreeViewCtrlCreateInstance();
         private static _GuiTreeViewCtrlCreateInstance _GuiTreeViewCtrlCreateInstanceFunc;
         internal static IntPtr GuiTreeViewCtrlCreateInstance()
         {
            if (_GuiTreeViewCtrlCreateInstanceFunc == null)
            {
               _GuiTreeViewCtrlCreateInstanceFunc =
                  (_GuiTreeViewCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlCreateInstance"), typeof(_GuiTreeViewCtrlCreateInstance));
            }

            return _GuiTreeViewCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlFindItemByName(IntPtr ctrl, string name);
         private static _GuiTreeViewCtrlFindItemByName _GuiTreeViewCtrlFindItemByNameFunc;
         internal static int GuiTreeViewCtrlFindItemByName(IntPtr ctrl, string name)
         {
            if (_GuiTreeViewCtrlFindItemByNameFunc == null)
            {
               _GuiTreeViewCtrlFindItemByNameFunc =
                  (_GuiTreeViewCtrlFindItemByName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlFindItemByName"), typeof(_GuiTreeViewCtrlFindItemByName));
            }

            return _GuiTreeViewCtrlFindItemByNameFunc(ctrl, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlInsertItem(IntPtr ctrl, int parent, string name, string value, string icon, int norm, int expand);
         private static _GuiTreeViewCtrlInsertItem _GuiTreeViewCtrlInsertItemFunc;
         internal static int GuiTreeViewCtrlInsertItem(IntPtr ctrl, int parent, string name, string value, string icon, int norm, int expand)
         {
            if (_GuiTreeViewCtrlInsertItemFunc == null)
            {
               _GuiTreeViewCtrlInsertItemFunc =
                  (_GuiTreeViewCtrlInsertItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlInsertItem"), typeof(_GuiTreeViewCtrlInsertItem));
            }

            return _GuiTreeViewCtrlInsertItemFunc(ctrl, parent, name, value, icon, norm, expand);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlLockSelection(IntPtr ctrl, bool locked);
         private static _GuiTreeViewCtrlLockSelection _GuiTreeViewCtrlLockSelectionFunc;
         internal static void GuiTreeViewCtrlLockSelection(IntPtr ctrl, bool locked)
         {
            if (_GuiTreeViewCtrlLockSelectionFunc == null)
            {
               _GuiTreeViewCtrlLockSelectionFunc =
                  (_GuiTreeViewCtrlLockSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlLockSelection"), typeof(_GuiTreeViewCtrlLockSelection));
            }

            _GuiTreeViewCtrlLockSelectionFunc(ctrl, locked);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlClearSelection(IntPtr ctrl);
         private static _GuiTreeViewCtrlClearSelection _GuiTreeViewCtrlClearSelectionFunc;
         internal static void GuiTreeViewCtrlClearSelection(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlClearSelectionFunc == null)
            {
               _GuiTreeViewCtrlClearSelectionFunc =
                  (_GuiTreeViewCtrlClearSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlClearSelection"), typeof(_GuiTreeViewCtrlClearSelection));
            }

            _GuiTreeViewCtrlClearSelectionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlDeleteSelection(IntPtr ctrl);
         private static _GuiTreeViewCtrlDeleteSelection _GuiTreeViewCtrlDeleteSelectionFunc;
         internal static void GuiTreeViewCtrlDeleteSelection(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlDeleteSelectionFunc == null)
            {
               _GuiTreeViewCtrlDeleteSelectionFunc =
                  (_GuiTreeViewCtrlDeleteSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlDeleteSelection"), typeof(_GuiTreeViewCtrlDeleteSelection));
            }

            _GuiTreeViewCtrlDeleteSelectionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlAddSelection(IntPtr ctrl, int ID);
         private static _GuiTreeViewCtrlAddSelection _GuiTreeViewCtrlAddSelectionFunc;
         internal static void GuiTreeViewCtrlAddSelection(IntPtr ctrl, int ID)
         {
            if (_GuiTreeViewCtrlAddSelectionFunc == null)
            {
               _GuiTreeViewCtrlAddSelectionFunc =
                  (_GuiTreeViewCtrlAddSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlAddSelection"), typeof(_GuiTreeViewCtrlAddSelection));
            }

            _GuiTreeViewCtrlAddSelectionFunc(ctrl, ID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlAddChildSelectionByValue(IntPtr ctrl, int parent, string value);
         private static _GuiTreeViewCtrlAddChildSelectionByValue _GuiTreeViewCtrlAddChildSelectionByValueFunc;
         internal static void GuiTreeViewCtrlAddChildSelectionByValue(IntPtr ctrl, int parent, string value)
         {
            if (_GuiTreeViewCtrlAddChildSelectionByValueFunc == null)
            {
               _GuiTreeViewCtrlAddChildSelectionByValueFunc =
                  (_GuiTreeViewCtrlAddChildSelectionByValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlAddChildSelectionByValue"), typeof(_GuiTreeViewCtrlAddChildSelectionByValue));
            }

            _GuiTreeViewCtrlAddChildSelectionByValueFunc(ctrl, parent, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlRemoveSelection(IntPtr ctrl, int ID);
         private static _GuiTreeViewCtrlRemoveSelection _GuiTreeViewCtrlRemoveSelectionFunc;
         internal static void GuiTreeViewCtrlRemoveSelection(IntPtr ctrl, int ID)
         {
            if (_GuiTreeViewCtrlRemoveSelectionFunc == null)
            {
               _GuiTreeViewCtrlRemoveSelectionFunc =
                  (_GuiTreeViewCtrlRemoveSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlRemoveSelection"), typeof(_GuiTreeViewCtrlRemoveSelection));
            }

            _GuiTreeViewCtrlRemoveSelectionFunc(ctrl, ID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlRemoveChildSelectionByValue(IntPtr ctrl, int parent, string value);
         private static _GuiTreeViewCtrlRemoveChildSelectionByValue _GuiTreeViewCtrlRemoveChildSelectionByValueFunc;
         internal static void GuiTreeViewCtrlRemoveChildSelectionByValue(IntPtr ctrl, int parent, string value)
         {
            if (_GuiTreeViewCtrlRemoveChildSelectionByValueFunc == null)
            {
               _GuiTreeViewCtrlRemoveChildSelectionByValueFunc =
                  (_GuiTreeViewCtrlRemoveChildSelectionByValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlRemoveChildSelectionByValue"), typeof(_GuiTreeViewCtrlRemoveChildSelectionByValue));
            }

            _GuiTreeViewCtrlRemoveChildSelectionByValueFunc(ctrl, parent, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlSelectItem(IntPtr ctrl, int item, bool select);
         private static _GuiTreeViewCtrlSelectItem _GuiTreeViewCtrlSelectItemFunc;
         internal static bool GuiTreeViewCtrlSelectItem(IntPtr ctrl, int item, bool select)
         {
            if (_GuiTreeViewCtrlSelectItemFunc == null)
            {
               _GuiTreeViewCtrlSelectItemFunc =
                  (_GuiTreeViewCtrlSelectItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlSelectItem"), typeof(_GuiTreeViewCtrlSelectItem));
            }

            return _GuiTreeViewCtrlSelectItemFunc(ctrl, item, select);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlExpandItem(IntPtr ctrl, int item, bool expand);
         private static _GuiTreeViewCtrlExpandItem _GuiTreeViewCtrlExpandItemFunc;
         internal static bool GuiTreeViewCtrlExpandItem(IntPtr ctrl, int item, bool expand)
         {
            if (_GuiTreeViewCtrlExpandItemFunc == null)
            {
               _GuiTreeViewCtrlExpandItemFunc =
                  (_GuiTreeViewCtrlExpandItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlExpandItem"), typeof(_GuiTreeViewCtrlExpandItem));
            }

            return _GuiTreeViewCtrlExpandItemFunc(ctrl, item, expand);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlScrollVisible(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlScrollVisible _GuiTreeViewCtrlScrollVisibleFunc;
         internal static void GuiTreeViewCtrlScrollVisible(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlScrollVisibleFunc == null)
            {
               _GuiTreeViewCtrlScrollVisibleFunc =
                  (_GuiTreeViewCtrlScrollVisible)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlScrollVisible"), typeof(_GuiTreeViewCtrlScrollVisible));
            }

            _GuiTreeViewCtrlScrollVisibleFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlBuildIconTable(IntPtr ctrl, string icons);
         private static _GuiTreeViewCtrlBuildIconTable _GuiTreeViewCtrlBuildIconTableFunc;
         internal static bool GuiTreeViewCtrlBuildIconTable(IntPtr ctrl, string icons)
         {
            if (_GuiTreeViewCtrlBuildIconTableFunc == null)
            {
               _GuiTreeViewCtrlBuildIconTableFunc =
                  (_GuiTreeViewCtrlBuildIconTable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlBuildIconTable"), typeof(_GuiTreeViewCtrlBuildIconTable));
            }

            return _GuiTreeViewCtrlBuildIconTableFunc(ctrl, icons);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlOpen(IntPtr ctrl, IntPtr target, bool okToEdit);
         private static _GuiTreeViewCtrlOpen _GuiTreeViewCtrlOpenFunc;
         internal static void GuiTreeViewCtrlOpen(IntPtr ctrl, IntPtr target, bool okToEdit)
         {
            if (_GuiTreeViewCtrlOpenFunc == null)
            {
               _GuiTreeViewCtrlOpenFunc =
                  (_GuiTreeViewCtrlOpen)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlOpen"), typeof(_GuiTreeViewCtrlOpen));
            }

            _GuiTreeViewCtrlOpenFunc(ctrl, target, okToEdit);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTreeViewCtrlGetItemText(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlGetItemText _GuiTreeViewCtrlGetItemTextFunc;
         internal static IntPtr GuiTreeViewCtrlGetItemText(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlGetItemTextFunc == null)
            {
               _GuiTreeViewCtrlGetItemTextFunc =
                  (_GuiTreeViewCtrlGetItemText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetItemText"), typeof(_GuiTreeViewCtrlGetItemText));
            }

            return _GuiTreeViewCtrlGetItemTextFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTreeViewCtrlGetItemValue(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlGetItemValue _GuiTreeViewCtrlGetItemValueFunc;
         internal static IntPtr GuiTreeViewCtrlGetItemValue(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlGetItemValueFunc == null)
            {
               _GuiTreeViewCtrlGetItemValueFunc =
                  (_GuiTreeViewCtrlGetItemValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetItemValue"), typeof(_GuiTreeViewCtrlGetItemValue));
            }

            return _GuiTreeViewCtrlGetItemValueFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlEditItem(IntPtr ctrl, int item, string newText, string newValue);
         private static _GuiTreeViewCtrlEditItem _GuiTreeViewCtrlEditItemFunc;
         internal static bool GuiTreeViewCtrlEditItem(IntPtr ctrl, int item, string newText, string newValue)
         {
            if (_GuiTreeViewCtrlEditItemFunc == null)
            {
               _GuiTreeViewCtrlEditItemFunc =
                  (_GuiTreeViewCtrlEditItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlEditItem"), typeof(_GuiTreeViewCtrlEditItem));
            }

            return _GuiTreeViewCtrlEditItemFunc(ctrl, item, newText, newValue);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTreeViewCtrlRemoveItem(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlRemoveItem _GuiTreeViewCtrlRemoveItemFunc;
         internal static bool GuiTreeViewCtrlRemoveItem(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlRemoveItemFunc == null)
            {
               _GuiTreeViewCtrlRemoveItemFunc =
                  (_GuiTreeViewCtrlRemoveItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlRemoveItem"), typeof(_GuiTreeViewCtrlRemoveItem));
            }

            return _GuiTreeViewCtrlRemoveItemFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlRemoveAllChildren(IntPtr ctrl, int parent);
         private static _GuiTreeViewCtrlRemoveAllChildren _GuiTreeViewCtrlRemoveAllChildrenFunc;
         internal static void GuiTreeViewCtrlRemoveAllChildren(IntPtr ctrl, int parent)
         {
            if (_GuiTreeViewCtrlRemoveAllChildrenFunc == null)
            {
               _GuiTreeViewCtrlRemoveAllChildrenFunc =
                  (_GuiTreeViewCtrlRemoveAllChildren)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlRemoveAllChildren"), typeof(_GuiTreeViewCtrlRemoveAllChildren));
            }

            _GuiTreeViewCtrlRemoveAllChildrenFunc(ctrl, parent);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlClear(IntPtr ctrl);
         private static _GuiTreeViewCtrlClear _GuiTreeViewCtrlClearFunc;
         internal static void GuiTreeViewCtrlClear(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlClearFunc == null)
            {
               _GuiTreeViewCtrlClearFunc =
                  (_GuiTreeViewCtrlClear)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlClear"), typeof(_GuiTreeViewCtrlClear));
            }

            _GuiTreeViewCtrlClearFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetFirstRootItem(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetFirstRootItem _GuiTreeViewCtrlGetFirstRootItemFunc;
         internal static int GuiTreeViewCtrlGetFirstRootItem(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetFirstRootItemFunc == null)
            {
               _GuiTreeViewCtrlGetFirstRootItemFunc =
                  (_GuiTreeViewCtrlGetFirstRootItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetFirstRootItem"), typeof(_GuiTreeViewCtrlGetFirstRootItem));
            }

            return _GuiTreeViewCtrlGetFirstRootItemFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetChild(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlGetChild _GuiTreeViewCtrlGetChildFunc;
         internal static int GuiTreeViewCtrlGetChild(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlGetChildFunc == null)
            {
               _GuiTreeViewCtrlGetChildFunc =
                  (_GuiTreeViewCtrlGetChild)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetChild"), typeof(_GuiTreeViewCtrlGetChild));
            }

            return _GuiTreeViewCtrlGetChildFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlBuildVisibleTree(IntPtr ctrl, bool forceFullUpdate);
         private static _GuiTreeViewCtrlBuildVisibleTree _GuiTreeViewCtrlBuildVisibleTreeFunc;
         internal static void GuiTreeViewCtrlBuildVisibleTree(IntPtr ctrl, bool forceFullUpdate)
         {
            if (_GuiTreeViewCtrlBuildVisibleTreeFunc == null)
            {
               _GuiTreeViewCtrlBuildVisibleTreeFunc =
                  (_GuiTreeViewCtrlBuildVisibleTree)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlBuildVisibleTree"), typeof(_GuiTreeViewCtrlBuildVisibleTree));
            }

            _GuiTreeViewCtrlBuildVisibleTreeFunc(ctrl, forceFullUpdate);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetParent(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlGetParent _GuiTreeViewCtrlGetParentFunc;
         internal static int GuiTreeViewCtrlGetParent(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlGetParentFunc == null)
            {
               _GuiTreeViewCtrlGetParentFunc =
                  (_GuiTreeViewCtrlGetParent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetParent"), typeof(_GuiTreeViewCtrlGetParent));
            }

            return _GuiTreeViewCtrlGetParentFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetNextSibling(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlGetNextSibling _GuiTreeViewCtrlGetNextSiblingFunc;
         internal static int GuiTreeViewCtrlGetNextSibling(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlGetNextSiblingFunc == null)
            {
               _GuiTreeViewCtrlGetNextSiblingFunc =
                  (_GuiTreeViewCtrlGetNextSibling)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetNextSibling"), typeof(_GuiTreeViewCtrlGetNextSibling));
            }

            return _GuiTreeViewCtrlGetNextSiblingFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetPrevSibling(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlGetPrevSibling _GuiTreeViewCtrlGetPrevSiblingFunc;
         internal static int GuiTreeViewCtrlGetPrevSibling(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlGetPrevSiblingFunc == null)
            {
               _GuiTreeViewCtrlGetPrevSiblingFunc =
                  (_GuiTreeViewCtrlGetPrevSibling)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetPrevSibling"), typeof(_GuiTreeViewCtrlGetPrevSibling));
            }

            return _GuiTreeViewCtrlGetPrevSiblingFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetItemCount(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetItemCount _GuiTreeViewCtrlGetItemCountFunc;
         internal static int GuiTreeViewCtrlGetItemCount(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetItemCountFunc == null)
            {
               _GuiTreeViewCtrlGetItemCountFunc =
                  (_GuiTreeViewCtrlGetItemCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetItemCount"), typeof(_GuiTreeViewCtrlGetItemCount));
            }

            return _GuiTreeViewCtrlGetItemCountFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetSelectedItem(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetSelectedItem _GuiTreeViewCtrlGetSelectedItemFunc;
         internal static int GuiTreeViewCtrlGetSelectedItem(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetSelectedItemFunc == null)
            {
               _GuiTreeViewCtrlGetSelectedItemFunc =
                  (_GuiTreeViewCtrlGetSelectedItem)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetSelectedItem"), typeof(_GuiTreeViewCtrlGetSelectedItem));
            }

            return _GuiTreeViewCtrlGetSelectedItemFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTreeViewCtrlGetSelectedObject(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetSelectedObject _GuiTreeViewCtrlGetSelectedObjectFunc;
         internal static IntPtr GuiTreeViewCtrlGetSelectedObject(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetSelectedObjectFunc == null)
            {
               _GuiTreeViewCtrlGetSelectedObjectFunc =
                  (_GuiTreeViewCtrlGetSelectedObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetSelectedObject"), typeof(_GuiTreeViewCtrlGetSelectedObject));
            }

            return _GuiTreeViewCtrlGetSelectedObjectFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlMoveItemUp(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlMoveItemUp _GuiTreeViewCtrlMoveItemUpFunc;
         internal static void GuiTreeViewCtrlMoveItemUp(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlMoveItemUpFunc == null)
            {
               _GuiTreeViewCtrlMoveItemUpFunc =
                  (_GuiTreeViewCtrlMoveItemUp)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlMoveItemUp"), typeof(_GuiTreeViewCtrlMoveItemUp));
            }

            _GuiTreeViewCtrlMoveItemUpFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTreeViewCtrlMoveItemDown(IntPtr ctrl, int item);
         private static _GuiTreeViewCtrlMoveItemDown _GuiTreeViewCtrlMoveItemDownFunc;
         internal static void GuiTreeViewCtrlMoveItemDown(IntPtr ctrl, int item)
         {
            if (_GuiTreeViewCtrlMoveItemDownFunc == null)
            {
               _GuiTreeViewCtrlMoveItemDownFunc =
                  (_GuiTreeViewCtrlMoveItemDown)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlMoveItemDown"), typeof(_GuiTreeViewCtrlMoveItemDown));
            }

            _GuiTreeViewCtrlMoveItemDownFunc(ctrl, item);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlGetSelectedItemsCount(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetSelectedItemsCount _GuiTreeViewCtrlGetSelectedItemsCountFunc;
         internal static int GuiTreeViewCtrlGetSelectedItemsCount(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetSelectedItemsCountFunc == null)
            {
               _GuiTreeViewCtrlGetSelectedItemsCountFunc =
                  (_GuiTreeViewCtrlGetSelectedItemsCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetSelectedItemsCount"), typeof(_GuiTreeViewCtrlGetSelectedItemsCount));
            }

            return _GuiTreeViewCtrlGetSelectedItemsCountFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTreeViewCtrlGetTextToRoot(IntPtr ctrl, int item, string delimiter);
         private static _GuiTreeViewCtrlGetTextToRoot _GuiTreeViewCtrlGetTextToRootFunc;
         internal static IntPtr GuiTreeViewCtrlGetTextToRoot(IntPtr ctrl, int item, string delimiter)
         {
            if (_GuiTreeViewCtrlGetTextToRootFunc == null)
            {
               _GuiTreeViewCtrlGetTextToRootFunc =
                  (_GuiTreeViewCtrlGetTextToRoot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetTextToRoot"), typeof(_GuiTreeViewCtrlGetTextToRoot));
            }

            return _GuiTreeViewCtrlGetTextToRootFunc(ctrl, item, delimiter);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTreeViewCtrlGetSelectedItemList(IntPtr ctrl);
         private static _GuiTreeViewCtrlGetSelectedItemList _GuiTreeViewCtrlGetSelectedItemListFunc;
         internal static IntPtr GuiTreeViewCtrlGetSelectedItemList(IntPtr ctrl)
         {
            if (_GuiTreeViewCtrlGetSelectedItemListFunc == null)
            {
               _GuiTreeViewCtrlGetSelectedItemListFunc =
                  (_GuiTreeViewCtrlGetSelectedItemList)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlGetSelectedItemList"), typeof(_GuiTreeViewCtrlGetSelectedItemList));
            }

            return _GuiTreeViewCtrlGetSelectedItemListFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlFindItemByObject(IntPtr ctrl, IntPtr obj);
         private static _GuiTreeViewCtrlFindItemByObject _GuiTreeViewCtrlFindItemByObjectFunc;
         internal static int GuiTreeViewCtrlFindItemByObject(IntPtr ctrl, IntPtr obj)
         {
            if (_GuiTreeViewCtrlFindItemByObjectFunc == null)
            {
               _GuiTreeViewCtrlFindItemByObjectFunc =
                  (_GuiTreeViewCtrlFindItemByObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlFindItemByObject"), typeof(_GuiTreeViewCtrlFindItemByObject));
            }

            return _GuiTreeViewCtrlFindItemByObjectFunc(ctrl, obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTreeViewCtrlScrollVisibleByObject(IntPtr ctrl, IntPtr obj);
         private static _GuiTreeViewCtrlScrollVisibleByObject _GuiTreeViewCtrlScrollVisibleByObjectFunc;
         internal static int GuiTreeViewCtrlScrollVisibleByObject(IntPtr ctrl, IntPtr obj)
         {
            if (_GuiTreeViewCtrlScrollVisibleByObjectFunc == null)
            {
               _GuiTreeViewCtrlScrollVisibleByObjectFunc =
                  (_GuiTreeViewCtrlScrollVisibleByObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTreeViewCtrlScrollVisibleByObject"), typeof(_GuiTreeViewCtrlScrollVisibleByObject));
            }

            return _GuiTreeViewCtrlScrollVisibleByObjectFunc(ctrl, obj);
         }
      }
      
      #endregion

      #region Properties

      public int TabSize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTreeViewCtrlGetTabSize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTreeViewCtrlSetTabSize(ObjectPtr->ObjPtr, value);
         }
      }
      public int TextOffset
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTreeViewCtrlGetTextOffset(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTreeViewCtrlSetTextOffset(ObjectPtr->ObjPtr, value);
         }
      }
      public bool FullRowSelect
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTreeViewCtrlGetFullRowSelect(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTreeViewCtrlSetFullRowSelect(ObjectPtr->ObjPtr, value);
         }
      }
      public int ItemHeight
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTreeViewCtrlGetItemHeight(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTreeViewCtrlSetItemHeight(ObjectPtr->ObjPtr, value);
         }
      }
      public bool DestroyTreeOnSleep
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTreeViewCtrlGetDestroyTreeOnSleep(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTreeViewCtrlSetDestroyTreeOnSleep(ObjectPtr->ObjPtr, value);
         }
      }
      public bool MouseDragging
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTreeViewCtrlGetMouseDragging(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTreeViewCtrlSetMouseDragging(ObjectPtr->ObjPtr, value);
         }
      }
      public bool MultipleSelections
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTreeViewCtrlGetMultipleSelections(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTreeViewCtrlSetMultipleSelections(ObjectPtr->ObjPtr, value);
         }
      }
      public bool DeleteObjectAllowed
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTreeViewCtrlGetDeleteObjectAllowed(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTreeViewCtrlSetDeleteObjectAllowed(ObjectPtr->ObjPtr, value);
         }
      }
      public bool DragToItemAllowed
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTreeViewCtrlGetDragToItemAllowed(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTreeViewCtrlSetDragToItemAllowed(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public int FindItemByName(string name)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlFindItemByName(ObjectPtr->ObjPtr, name);
      }

      public int InsertItem(int parent, string name, string value, string icon, int norm, int expand)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlInsertItem(ObjectPtr->ObjPtr, parent, name, value, icon, norm, expand);
      }

      public void LockSelection(bool locked)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlLockSelection(ObjectPtr->ObjPtr, locked);
      }

      public void ClearSelection()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlClearSelection(ObjectPtr->ObjPtr);
      }

      public void DeleteSelection()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlDeleteSelection(ObjectPtr->ObjPtr);
      }

      public void AddSelection(int ID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlAddSelection(ObjectPtr->ObjPtr, ID);
      }

      public void AddChildSelectionByValue(int parent, string value)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlAddChildSelectionByValue(ObjectPtr->ObjPtr, parent, value);
      }

      public void RemoveSelection(int ID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlRemoveSelection(ObjectPtr->ObjPtr, ID);
      }

      public void RemoveChildSelectionByValue(int parent, string value)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlRemoveChildSelectionByValue(ObjectPtr->ObjPtr, parent, value);
      }

      public bool SelectItem(int item, bool select)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlSelectItem(ObjectPtr->ObjPtr, item, select);
      }

      public bool ExpandItem(int item, bool expand)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlExpandItem(ObjectPtr->ObjPtr, item, expand);
      }

      public void ScrollVisible(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlScrollVisible(ObjectPtr->ObjPtr, item);
      }

      public bool BuildIconTable(string icons)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlBuildIconTable(ObjectPtr->ObjPtr, icons);
      }

      public void Open(SimSet target, bool okToEdit)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlOpen(ObjectPtr->ObjPtr, target.ObjectPtr->ObjPtr, okToEdit);
      }

      public string GetItemText(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTreeViewCtrlGetItemText(ObjectPtr->ObjPtr, item));
      }

      public string GetItemValue(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTreeViewCtrlGetItemValue(ObjectPtr->ObjPtr, item));
      }

      public bool EditItem(int item, string newText, string newValue)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlEditItem(ObjectPtr->ObjPtr, item, newText, newValue);
      }

      public bool RemoveItem(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlRemoveItem(ObjectPtr->ObjPtr, item);
      }

      public void RemoveAllChildren(int parent)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlRemoveAllChildren(ObjectPtr->ObjPtr, parent);
      }

      public void Clear()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlClear(ObjectPtr->ObjPtr);
      }

      public int GetFirstRootItem()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlGetFirstRootItem(ObjectPtr->ObjPtr);
      }

      public int GetChild(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlGetChild(ObjectPtr->ObjPtr, item);
      }

      public void BuildVisibleTree(bool forceFullUpdate)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlBuildVisibleTree(ObjectPtr->ObjPtr, forceFullUpdate);
      }

      public int GetParent(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlGetParent(ObjectPtr->ObjPtr, item);
      }

      public int GetNextSibling(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlGetNextSibling(ObjectPtr->ObjPtr, item);
      }

      public int GetPrevSibling(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlGetPrevSibling(ObjectPtr->ObjPtr, item);
      }

      public int GetItemCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlGetItemCount(ObjectPtr->ObjPtr);
      }

      public int GetSelectedItem()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlGetSelectedItem(ObjectPtr->ObjPtr);
      }

      public SimObject GetSelectedObject()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimObject(InternalUnsafeMethods.GuiTreeViewCtrlGetSelectedObject(ObjectPtr->ObjPtr));
      }

      public void MoveItemUp(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlMoveItemUp(ObjectPtr->ObjPtr, item);
      }

      public void MoveItemDown(int item)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTreeViewCtrlMoveItemDown(ObjectPtr->ObjPtr, item);
      }

      public int GetSelectedItemsCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlGetSelectedItemsCount(ObjectPtr->ObjPtr);
      }

      public string GetTextToRoot(int item, string delimiter)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTreeViewCtrlGetTextToRoot(ObjectPtr->ObjPtr, item, delimiter));
      }

      public string GetSelectedItemList()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTreeViewCtrlGetSelectedItemList(ObjectPtr->ObjPtr));
      }

      public int FindItemByObject(SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlFindItemByObject(ObjectPtr->ObjPtr, obj.ObjectPtr->ObjPtr);
      }

      public int ScrollVisibleByObject(SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTreeViewCtrlScrollVisibleByObject(ObjectPtr->ObjPtr, obj.ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}