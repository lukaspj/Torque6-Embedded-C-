using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiTextListCtrl : GuiArrayCtrl
   {
      
      public GuiTextListCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiTextListCtrlCreateInstance());
      }

      public GuiTextListCtrl(uint pId) : base(pId)
      {
      }

      public GuiTextListCtrl(string pName) : base(pName)
      {
      }

      public GuiTextListCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTextListCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTextListCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTextListCtrlGetEnumerate(IntPtr ctrl);
         private static _GuiTextListCtrlGetEnumerate _GuiTextListCtrlGetEnumerateFunc;
         internal static bool GuiTextListCtrlGetEnumerate(IntPtr ctrl)
         {
            if (_GuiTextListCtrlGetEnumerateFunc == null)
            {
               _GuiTextListCtrlGetEnumerateFunc =
                  (_GuiTextListCtrlGetEnumerate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetEnumerate"), typeof(_GuiTextListCtrlGetEnumerate));
            }

            return _GuiTextListCtrlGetEnumerateFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSetEnumerate(IntPtr ctrl, bool enumerate);
         private static _GuiTextListCtrlSetEnumerate _GuiTextListCtrlSetEnumerateFunc;
         internal static void GuiTextListCtrlSetEnumerate(IntPtr ctrl, bool enumerate)
         {
            if (_GuiTextListCtrlSetEnumerateFunc == null)
            {
               _GuiTextListCtrlSetEnumerateFunc =
                  (_GuiTextListCtrlSetEnumerate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSetEnumerate"), typeof(_GuiTextListCtrlSetEnumerate));
            }

            _GuiTextListCtrlSetEnumerateFunc(ctrl, enumerate);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTextListCtrlGetResizeCell(IntPtr ctrl);
         private static _GuiTextListCtrlGetResizeCell _GuiTextListCtrlGetResizeCellFunc;
         internal static bool GuiTextListCtrlGetResizeCell(IntPtr ctrl)
         {
            if (_GuiTextListCtrlGetResizeCellFunc == null)
            {
               _GuiTextListCtrlGetResizeCellFunc =
                  (_GuiTextListCtrlGetResizeCell)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetResizeCell"), typeof(_GuiTextListCtrlGetResizeCell));
            }

            return _GuiTextListCtrlGetResizeCellFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSetResizeCell(IntPtr ctrl, bool resize);
         private static _GuiTextListCtrlSetResizeCell _GuiTextListCtrlSetResizeCellFunc;
         internal static void GuiTextListCtrlSetResizeCell(IntPtr ctrl, bool resize)
         {
            if (_GuiTextListCtrlSetResizeCellFunc == null)
            {
               _GuiTextListCtrlSetResizeCellFunc =
                  (_GuiTextListCtrlSetResizeCell)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSetResizeCell"), typeof(_GuiTextListCtrlSetResizeCell));
            }

            _GuiTextListCtrlSetResizeCellFunc(ctrl, resize);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTextListCtrlGetFitParentWidth(IntPtr ctrl);
         private static _GuiTextListCtrlGetFitParentWidth _GuiTextListCtrlGetFitParentWidthFunc;
         internal static bool GuiTextListCtrlGetFitParentWidth(IntPtr ctrl)
         {
            if (_GuiTextListCtrlGetFitParentWidthFunc == null)
            {
               _GuiTextListCtrlGetFitParentWidthFunc =
                  (_GuiTextListCtrlGetFitParentWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetFitParentWidth"), typeof(_GuiTextListCtrlGetFitParentWidth));
            }

            return _GuiTextListCtrlGetFitParentWidthFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSetFitParentWidth(IntPtr ctrl, bool fitParentWidth);
         private static _GuiTextListCtrlSetFitParentWidth _GuiTextListCtrlSetFitParentWidthFunc;
         internal static void GuiTextListCtrlSetFitParentWidth(IntPtr ctrl, bool fitParentWidth)
         {
            if (_GuiTextListCtrlSetFitParentWidthFunc == null)
            {
               _GuiTextListCtrlSetFitParentWidthFunc =
                  (_GuiTextListCtrlSetFitParentWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSetFitParentWidth"), typeof(_GuiTextListCtrlSetFitParentWidth));
            }

            _GuiTextListCtrlSetFitParentWidthFunc(ctrl, fitParentWidth);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTextListCtrlGetClipColumnText(IntPtr ctrl);
         private static _GuiTextListCtrlGetClipColumnText _GuiTextListCtrlGetClipColumnTextFunc;
         internal static bool GuiTextListCtrlGetClipColumnText(IntPtr ctrl)
         {
            if (_GuiTextListCtrlGetClipColumnTextFunc == null)
            {
               _GuiTextListCtrlGetClipColumnTextFunc =
                  (_GuiTextListCtrlGetClipColumnText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetClipColumnText"), typeof(_GuiTextListCtrlGetClipColumnText));
            }

            return _GuiTextListCtrlGetClipColumnTextFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSetClipColumnText(IntPtr ctrl, bool clip);
         private static _GuiTextListCtrlSetClipColumnText _GuiTextListCtrlSetClipColumnTextFunc;
         internal static void GuiTextListCtrlSetClipColumnText(IntPtr ctrl, bool clip)
         {
            if (_GuiTextListCtrlSetClipColumnTextFunc == null)
            {
               _GuiTextListCtrlSetClipColumnTextFunc =
                  (_GuiTextListCtrlSetClipColumnText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSetClipColumnText"), typeof(_GuiTextListCtrlSetClipColumnText));
            }

            _GuiTextListCtrlSetClipColumnTextFunc(ctrl, clip);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextListCtrlCreateInstance();
         private static _GuiTextListCtrlCreateInstance _GuiTextListCtrlCreateInstanceFunc;
         internal static IntPtr GuiTextListCtrlCreateInstance()
         {
            if (_GuiTextListCtrlCreateInstanceFunc == null)
            {
               _GuiTextListCtrlCreateInstanceFunc =
                  (_GuiTextListCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlCreateInstance"), typeof(_GuiTextListCtrlCreateInstance));
            }

            return _GuiTextListCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate uint _GuiTextListCtrlGetSelectedId(IntPtr ctrl);
         private static _GuiTextListCtrlGetSelectedId _GuiTextListCtrlGetSelectedIdFunc;
         internal static uint GuiTextListCtrlGetSelectedId(IntPtr ctrl)
         {
            if (_GuiTextListCtrlGetSelectedIdFunc == null)
            {
               _GuiTextListCtrlGetSelectedIdFunc =
                  (_GuiTextListCtrlGetSelectedId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetSelectedId"), typeof(_GuiTextListCtrlGetSelectedId));
            }

            return _GuiTextListCtrlGetSelectedIdFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSetSelectedById(IntPtr ctrl, uint ID);
         private static _GuiTextListCtrlSetSelectedById _GuiTextListCtrlSetSelectedByIdFunc;
         internal static void GuiTextListCtrlSetSelectedById(IntPtr ctrl, uint ID)
         {
            if (_GuiTextListCtrlSetSelectedByIdFunc == null)
            {
               _GuiTextListCtrlSetSelectedByIdFunc =
                  (_GuiTextListCtrlSetSelectedById)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSetSelectedById"), typeof(_GuiTextListCtrlSetSelectedById));
            }

            _GuiTextListCtrlSetSelectedByIdFunc(ctrl, ID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSetSelectedRow(IntPtr ctrl, uint rowNum);
         private static _GuiTextListCtrlSetSelectedRow _GuiTextListCtrlSetSelectedRowFunc;
         internal static void GuiTextListCtrlSetSelectedRow(IntPtr ctrl, uint rowNum)
         {
            if (_GuiTextListCtrlSetSelectedRowFunc == null)
            {
               _GuiTextListCtrlSetSelectedRowFunc =
                  (_GuiTextListCtrlSetSelectedRow)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSetSelectedRow"), typeof(_GuiTextListCtrlSetSelectedRow));
            }

            _GuiTextListCtrlSetSelectedRowFunc(ctrl, rowNum);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate uint _GuiTextListCtrlGetSelectedRow(IntPtr ctrl);
         private static _GuiTextListCtrlGetSelectedRow _GuiTextListCtrlGetSelectedRowFunc;
         internal static uint GuiTextListCtrlGetSelectedRow(IntPtr ctrl)
         {
            if (_GuiTextListCtrlGetSelectedRowFunc == null)
            {
               _GuiTextListCtrlGetSelectedRowFunc =
                  (_GuiTextListCtrlGetSelectedRow)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetSelectedRow"), typeof(_GuiTextListCtrlGetSelectedRow));
            }

            return _GuiTextListCtrlGetSelectedRowFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlClearSelection(IntPtr ctrl);
         private static _GuiTextListCtrlClearSelection _GuiTextListCtrlClearSelectionFunc;
         internal static void GuiTextListCtrlClearSelection(IntPtr ctrl)
         {
            if (_GuiTextListCtrlClearSelectionFunc == null)
            {
               _GuiTextListCtrlClearSelectionFunc =
                  (_GuiTextListCtrlClearSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlClearSelection"), typeof(_GuiTextListCtrlClearSelection));
            }

            _GuiTextListCtrlClearSelectionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTextListCtrlAddRow(IntPtr ctrl, uint ID, string text, int row);
         private static _GuiTextListCtrlAddRow _GuiTextListCtrlAddRowFunc;
         internal static int GuiTextListCtrlAddRow(IntPtr ctrl, uint ID, string text, int row)
         {
            if (_GuiTextListCtrlAddRowFunc == null)
            {
               _GuiTextListCtrlAddRowFunc =
                  (_GuiTextListCtrlAddRow)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlAddRow"), typeof(_GuiTextListCtrlAddRow));
            }

            return _GuiTextListCtrlAddRowFunc(ctrl, ID, text, row);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSetRowById(IntPtr ctrl, uint ID, string text);
         private static _GuiTextListCtrlSetRowById _GuiTextListCtrlSetRowByIdFunc;
         internal static void GuiTextListCtrlSetRowById(IntPtr ctrl, uint ID, string text)
         {
            if (_GuiTextListCtrlSetRowByIdFunc == null)
            {
               _GuiTextListCtrlSetRowByIdFunc =
                  (_GuiTextListCtrlSetRowById)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSetRowById"), typeof(_GuiTextListCtrlSetRowById));
            }

            _GuiTextListCtrlSetRowByIdFunc(ctrl, ID, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSort(IntPtr ctrl, uint columnID, bool ascending);
         private static _GuiTextListCtrlSort _GuiTextListCtrlSortFunc;
         internal static void GuiTextListCtrlSort(IntPtr ctrl, uint columnID, bool ascending)
         {
            if (_GuiTextListCtrlSortFunc == null)
            {
               _GuiTextListCtrlSortFunc =
                  (_GuiTextListCtrlSort)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSort"), typeof(_GuiTextListCtrlSort));
            }

            _GuiTextListCtrlSortFunc(ctrl, columnID, ascending);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSortNumerical(IntPtr ctrl, uint columnID, bool ascending);
         private static _GuiTextListCtrlSortNumerical _GuiTextListCtrlSortNumericalFunc;
         internal static void GuiTextListCtrlSortNumerical(IntPtr ctrl, uint columnID, bool ascending)
         {
            if (_GuiTextListCtrlSortNumericalFunc == null)
            {
               _GuiTextListCtrlSortNumericalFunc =
                  (_GuiTextListCtrlSortNumerical)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSortNumerical"), typeof(_GuiTextListCtrlSortNumerical));
            }

            _GuiTextListCtrlSortNumericalFunc(ctrl, columnID, ascending);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlClear(IntPtr ctrl);
         private static _GuiTextListCtrlClear _GuiTextListCtrlClearFunc;
         internal static void GuiTextListCtrlClear(IntPtr ctrl)
         {
            if (_GuiTextListCtrlClearFunc == null)
            {
               _GuiTextListCtrlClearFunc =
                  (_GuiTextListCtrlClear)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlClear"), typeof(_GuiTextListCtrlClear));
            }

            _GuiTextListCtrlClearFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate uint _GuiTextListCtrlRowCount(IntPtr ctrl);
         private static _GuiTextListCtrlRowCount _GuiTextListCtrlRowCountFunc;
         internal static uint GuiTextListCtrlRowCount(IntPtr ctrl)
         {
            if (_GuiTextListCtrlRowCountFunc == null)
            {
               _GuiTextListCtrlRowCountFunc =
                  (_GuiTextListCtrlRowCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlRowCount"), typeof(_GuiTextListCtrlRowCount));
            }

            return _GuiTextListCtrlRowCountFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate uint _GuiTextListCtrlGetRowId(IntPtr ctrl, uint row);
         private static _GuiTextListCtrlGetRowId _GuiTextListCtrlGetRowIdFunc;
         internal static uint GuiTextListCtrlGetRowId(IntPtr ctrl, uint row)
         {
            if (_GuiTextListCtrlGetRowIdFunc == null)
            {
               _GuiTextListCtrlGetRowIdFunc =
                  (_GuiTextListCtrlGetRowId)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetRowId"), typeof(_GuiTextListCtrlGetRowId));
            }

            return _GuiTextListCtrlGetRowIdFunc(ctrl, row);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextListCtrlGetRowTextById(IntPtr ctrl, uint ID);
         private static _GuiTextListCtrlGetRowTextById _GuiTextListCtrlGetRowTextByIdFunc;
         internal static IntPtr GuiTextListCtrlGetRowTextById(IntPtr ctrl, uint ID)
         {
            if (_GuiTextListCtrlGetRowTextByIdFunc == null)
            {
               _GuiTextListCtrlGetRowTextByIdFunc =
                  (_GuiTextListCtrlGetRowTextById)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetRowTextById"), typeof(_GuiTextListCtrlGetRowTextById));
            }

            return _GuiTextListCtrlGetRowTextByIdFunc(ctrl, ID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTextListCtrlGetRowNumById(IntPtr ctrl, uint ID);
         private static _GuiTextListCtrlGetRowNumById _GuiTextListCtrlGetRowNumByIdFunc;
         internal static int GuiTextListCtrlGetRowNumById(IntPtr ctrl, uint ID)
         {
            if (_GuiTextListCtrlGetRowNumByIdFunc == null)
            {
               _GuiTextListCtrlGetRowNumByIdFunc =
                  (_GuiTextListCtrlGetRowNumById)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetRowNumById"), typeof(_GuiTextListCtrlGetRowNumById));
            }

            return _GuiTextListCtrlGetRowNumByIdFunc(ctrl, ID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextListCtrlGetRowText(IntPtr ctrl, uint row);
         private static _GuiTextListCtrlGetRowText _GuiTextListCtrlGetRowTextFunc;
         internal static IntPtr GuiTextListCtrlGetRowText(IntPtr ctrl, uint row)
         {
            if (_GuiTextListCtrlGetRowTextFunc == null)
            {
               _GuiTextListCtrlGetRowTextFunc =
                  (_GuiTextListCtrlGetRowText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlGetRowText"), typeof(_GuiTextListCtrlGetRowText));
            }

            return _GuiTextListCtrlGetRowTextFunc(ctrl, row);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlRemoveRowById(IntPtr ctrl, uint ID);
         private static _GuiTextListCtrlRemoveRowById _GuiTextListCtrlRemoveRowByIdFunc;
         internal static void GuiTextListCtrlRemoveRowById(IntPtr ctrl, uint ID)
         {
            if (_GuiTextListCtrlRemoveRowByIdFunc == null)
            {
               _GuiTextListCtrlRemoveRowByIdFunc =
                  (_GuiTextListCtrlRemoveRowById)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlRemoveRowById"), typeof(_GuiTextListCtrlRemoveRowById));
            }

            _GuiTextListCtrlRemoveRowByIdFunc(ctrl, ID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlRemoveRow(IntPtr ctrl, int row);
         private static _GuiTextListCtrlRemoveRow _GuiTextListCtrlRemoveRowFunc;
         internal static void GuiTextListCtrlRemoveRow(IntPtr ctrl, int row)
         {
            if (_GuiTextListCtrlRemoveRowFunc == null)
            {
               _GuiTextListCtrlRemoveRowFunc =
                  (_GuiTextListCtrlRemoveRow)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlRemoveRow"), typeof(_GuiTextListCtrlRemoveRow));
            }

            _GuiTextListCtrlRemoveRowFunc(ctrl, row);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlScrollVisible(IntPtr ctrl, uint row);
         private static _GuiTextListCtrlScrollVisible _GuiTextListCtrlScrollVisibleFunc;
         internal static void GuiTextListCtrlScrollVisible(IntPtr ctrl, uint row)
         {
            if (_GuiTextListCtrlScrollVisibleFunc == null)
            {
               _GuiTextListCtrlScrollVisibleFunc =
                  (_GuiTextListCtrlScrollVisible)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlScrollVisible"), typeof(_GuiTextListCtrlScrollVisible));
            }

            _GuiTextListCtrlScrollVisibleFunc(ctrl, row);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTextListCtrlFindTextIndex(IntPtr ctrl, string text);
         private static _GuiTextListCtrlFindTextIndex _GuiTextListCtrlFindTextIndexFunc;
         internal static int GuiTextListCtrlFindTextIndex(IntPtr ctrl, string text)
         {
            if (_GuiTextListCtrlFindTextIndexFunc == null)
            {
               _GuiTextListCtrlFindTextIndexFunc =
                  (_GuiTextListCtrlFindTextIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlFindTextIndex"), typeof(_GuiTextListCtrlFindTextIndex));
            }

            return _GuiTextListCtrlFindTextIndexFunc(ctrl, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextListCtrlSetRowActive(IntPtr ctrl, uint row, bool active);
         private static _GuiTextListCtrlSetRowActive _GuiTextListCtrlSetRowActiveFunc;
         internal static void GuiTextListCtrlSetRowActive(IntPtr ctrl, uint row, bool active)
         {
            if (_GuiTextListCtrlSetRowActiveFunc == null)
            {
               _GuiTextListCtrlSetRowActiveFunc =
                  (_GuiTextListCtrlSetRowActive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlSetRowActive"), typeof(_GuiTextListCtrlSetRowActive));
            }

            _GuiTextListCtrlSetRowActiveFunc(ctrl, row, active);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTextListCtrlIsRowActive(IntPtr ctrl, uint row);
         private static _GuiTextListCtrlIsRowActive _GuiTextListCtrlIsRowActiveFunc;
         internal static bool GuiTextListCtrlIsRowActive(IntPtr ctrl, uint row)
         {
            if (_GuiTextListCtrlIsRowActiveFunc == null)
            {
               _GuiTextListCtrlIsRowActiveFunc =
                  (_GuiTextListCtrlIsRowActive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextListCtrlIsRowActive"), typeof(_GuiTextListCtrlIsRowActive));
            }

            return _GuiTextListCtrlIsRowActiveFunc(ctrl, row);
         }
      }
      
      #endregion

      #region Properties

      public bool Enumerate
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextListCtrlGetEnumerate(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextListCtrlSetEnumerate(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ResizeCell
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextListCtrlGetResizeCell(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextListCtrlSetResizeCell(ObjectPtr->ObjPtr, value);
         }
      }
      public bool FitParentWidth
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextListCtrlGetFitParentWidth(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextListCtrlSetFitParentWidth(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ClipColumnText
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextListCtrlGetClipColumnText(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextListCtrlSetClipColumnText(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public uint GetSelectedId()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTextListCtrlGetSelectedId(ObjectPtr->ObjPtr);
      }

      public void SetSelectedById(uint ID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlSetSelectedById(ObjectPtr->ObjPtr, ID);
      }

      public void SetSelectedRow(uint rowNum)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlSetSelectedRow(ObjectPtr->ObjPtr, rowNum);
      }

      public uint GetSelectedRow()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTextListCtrlGetSelectedRow(ObjectPtr->ObjPtr);
      }

      public void ClearSelection()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlClearSelection(ObjectPtr->ObjPtr);
      }

      public int AddRow(uint ID, string text, int row)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTextListCtrlAddRow(ObjectPtr->ObjPtr, ID, text, row);
      }

      public void SetRowById(uint ID, string text)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlSetRowById(ObjectPtr->ObjPtr, ID, text);
      }

      public void Sort(uint columnID, bool ascending)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlSort(ObjectPtr->ObjPtr, columnID, ascending);
      }

      public void SortNumerical(uint columnID, bool ascending)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlSortNumerical(ObjectPtr->ObjPtr, columnID, ascending);
      }

      public void Clear()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlClear(ObjectPtr->ObjPtr);
      }

      public uint RowCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTextListCtrlRowCount(ObjectPtr->ObjPtr);
      }

      public uint GetRowId(uint row)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTextListCtrlGetRowId(ObjectPtr->ObjPtr, row);
      }

      public string GetRowTextById(uint ID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTextListCtrlGetRowTextById(ObjectPtr->ObjPtr, ID));
      }

      public int GetRowNumById(uint ID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTextListCtrlGetRowNumById(ObjectPtr->ObjPtr, ID);
      }

      public string GetRowText(uint row)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTextListCtrlGetRowText(ObjectPtr->ObjPtr, row));
      }

      public void RemoveRowById(uint ID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlRemoveRowById(ObjectPtr->ObjPtr, ID);
      }

      public void RemoveRow(int row)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlRemoveRow(ObjectPtr->ObjPtr, row);
      }

      public void ScrollVisible(uint row)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlScrollVisible(ObjectPtr->ObjPtr, row);
      }

      public int FindTextIndex(string text)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTextListCtrlFindTextIndex(ObjectPtr->ObjPtr, text);
      }

      public void SetRowActive(uint row, bool active)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextListCtrlSetRowActive(ObjectPtr->ObjPtr, row, active);
      }

      public bool IsRowActive(uint row)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTextListCtrlIsRowActive(ObjectPtr->ObjPtr, row);
      }
      
      #endregion

      
   }
}