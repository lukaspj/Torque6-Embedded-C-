using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiEditCtrl : GuiControl
   {
      
      public GuiEditCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiEditCtrlCreateInstance());
      }

      public GuiEditCtrl(uint pId) : base(pId)
      {
      }

      public GuiEditCtrl(string pName) : base(pName)
      {
      }

      public GuiEditCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiEditCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiEditCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiEditCtrlCreateInstance();
         private static _GuiEditCtrlCreateInstance _GuiEditCtrlCreateInstanceFunc;
         internal static IntPtr GuiEditCtrlCreateInstance()
         {
            if (_GuiEditCtrlCreateInstanceFunc == null)
            {
               _GuiEditCtrlCreateInstanceFunc =
                  (_GuiEditCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlCreateInstance"), typeof(_GuiEditCtrlCreateInstance));
            }

            return _GuiEditCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlSetRoot(IntPtr ctrl, IntPtr root);
         private static _GuiEditCtrlSetRoot _GuiEditCtrlSetRootFunc;
         internal static void GuiEditCtrlSetRoot(IntPtr ctrl, IntPtr root)
         {
            if (_GuiEditCtrlSetRootFunc == null)
            {
               _GuiEditCtrlSetRootFunc =
                  (_GuiEditCtrlSetRoot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlSetRoot"), typeof(_GuiEditCtrlSetRoot));
            }

            _GuiEditCtrlSetRootFunc(ctrl, root);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlAddNewCtrl(IntPtr ctrl, IntPtr root);
         private static _GuiEditCtrlAddNewCtrl _GuiEditCtrlAddNewCtrlFunc;
         internal static void GuiEditCtrlAddNewCtrl(IntPtr ctrl, IntPtr root)
         {
            if (_GuiEditCtrlAddNewCtrlFunc == null)
            {
               _GuiEditCtrlAddNewCtrlFunc =
                  (_GuiEditCtrlAddNewCtrl)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlAddNewCtrl"), typeof(_GuiEditCtrlAddNewCtrl));
            }

            _GuiEditCtrlAddNewCtrlFunc(ctrl, root);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlAddSelection(IntPtr ctrl, int ctrlID);
         private static _GuiEditCtrlAddSelection _GuiEditCtrlAddSelectionFunc;
         internal static void GuiEditCtrlAddSelection(IntPtr ctrl, int ctrlID)
         {
            if (_GuiEditCtrlAddSelectionFunc == null)
            {
               _GuiEditCtrlAddSelectionFunc =
                  (_GuiEditCtrlAddSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlAddSelection"), typeof(_GuiEditCtrlAddSelection));
            }

            _GuiEditCtrlAddSelectionFunc(ctrl, ctrlID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlRemoveSelection(IntPtr ctrl, int ctrlID);
         private static _GuiEditCtrlRemoveSelection _GuiEditCtrlRemoveSelectionFunc;
         internal static void GuiEditCtrlRemoveSelection(IntPtr ctrl, int ctrlID)
         {
            if (_GuiEditCtrlRemoveSelectionFunc == null)
            {
               _GuiEditCtrlRemoveSelectionFunc =
                  (_GuiEditCtrlRemoveSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlRemoveSelection"), typeof(_GuiEditCtrlRemoveSelection));
            }

            _GuiEditCtrlRemoveSelectionFunc(ctrl, ctrlID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlClearSelection(IntPtr ctrl);
         private static _GuiEditCtrlClearSelection _GuiEditCtrlClearSelectionFunc;
         internal static void GuiEditCtrlClearSelection(IntPtr ctrl)
         {
            if (_GuiEditCtrlClearSelectionFunc == null)
            {
               _GuiEditCtrlClearSelectionFunc =
                  (_GuiEditCtrlClearSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlClearSelection"), typeof(_GuiEditCtrlClearSelection));
            }

            _GuiEditCtrlClearSelectionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlSelect(IntPtr ctrl, IntPtr selCtrl);
         private static _GuiEditCtrlSelect _GuiEditCtrlSelectFunc;
         internal static void GuiEditCtrlSelect(IntPtr ctrl, IntPtr selCtrl)
         {
            if (_GuiEditCtrlSelectFunc == null)
            {
               _GuiEditCtrlSelectFunc =
                  (_GuiEditCtrlSelect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlSelect"), typeof(_GuiEditCtrlSelect));
            }

            _GuiEditCtrlSelectFunc(ctrl, selCtrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlSetCurrentAddSet(IntPtr ctrl, IntPtr selCtrl);
         private static _GuiEditCtrlSetCurrentAddSet _GuiEditCtrlSetCurrentAddSetFunc;
         internal static void GuiEditCtrlSetCurrentAddSet(IntPtr ctrl, IntPtr selCtrl)
         {
            if (_GuiEditCtrlSetCurrentAddSetFunc == null)
            {
               _GuiEditCtrlSetCurrentAddSetFunc =
                  (_GuiEditCtrlSetCurrentAddSet)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlSetCurrentAddSet"), typeof(_GuiEditCtrlSetCurrentAddSet));
            }

            _GuiEditCtrlSetCurrentAddSetFunc(ctrl, selCtrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiEditCtrlGetCurrentAddSet(IntPtr ctrl);
         private static _GuiEditCtrlGetCurrentAddSet _GuiEditCtrlGetCurrentAddSetFunc;
         internal static IntPtr GuiEditCtrlGetCurrentAddSet(IntPtr ctrl)
         {
            if (_GuiEditCtrlGetCurrentAddSetFunc == null)
            {
               _GuiEditCtrlGetCurrentAddSetFunc =
                  (_GuiEditCtrlGetCurrentAddSet)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlGetCurrentAddSet"), typeof(_GuiEditCtrlGetCurrentAddSet));
            }

            return _GuiEditCtrlGetCurrentAddSetFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlToggle(IntPtr ctrl);
         private static _GuiEditCtrlToggle _GuiEditCtrlToggleFunc;
         internal static void GuiEditCtrlToggle(IntPtr ctrl)
         {
            if (_GuiEditCtrlToggleFunc == null)
            {
               _GuiEditCtrlToggleFunc =
                  (_GuiEditCtrlToggle)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlToggle"), typeof(_GuiEditCtrlToggle));
            }

            _GuiEditCtrlToggleFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlJustify(IntPtr ctrl, int mode);
         private static _GuiEditCtrlJustify _GuiEditCtrlJustifyFunc;
         internal static void GuiEditCtrlJustify(IntPtr ctrl, int mode)
         {
            if (_GuiEditCtrlJustifyFunc == null)
            {
               _GuiEditCtrlJustifyFunc =
                  (_GuiEditCtrlJustify)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlJustify"), typeof(_GuiEditCtrlJustify));
            }

            _GuiEditCtrlJustifyFunc(ctrl, mode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlBringToFront(IntPtr ctrl);
         private static _GuiEditCtrlBringToFront _GuiEditCtrlBringToFrontFunc;
         internal static void GuiEditCtrlBringToFront(IntPtr ctrl)
         {
            if (_GuiEditCtrlBringToFrontFunc == null)
            {
               _GuiEditCtrlBringToFrontFunc =
                  (_GuiEditCtrlBringToFront)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlBringToFront"), typeof(_GuiEditCtrlBringToFront));
            }

            _GuiEditCtrlBringToFrontFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlPushToBack(IntPtr ctrl);
         private static _GuiEditCtrlPushToBack _GuiEditCtrlPushToBackFunc;
         internal static void GuiEditCtrlPushToBack(IntPtr ctrl)
         {
            if (_GuiEditCtrlPushToBackFunc == null)
            {
               _GuiEditCtrlPushToBackFunc =
                  (_GuiEditCtrlPushToBack)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlPushToBack"), typeof(_GuiEditCtrlPushToBack));
            }

            _GuiEditCtrlPushToBackFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlDeleteSelection(IntPtr ctrl);
         private static _GuiEditCtrlDeleteSelection _GuiEditCtrlDeleteSelectionFunc;
         internal static void GuiEditCtrlDeleteSelection(IntPtr ctrl)
         {
            if (_GuiEditCtrlDeleteSelectionFunc == null)
            {
               _GuiEditCtrlDeleteSelectionFunc =
                  (_GuiEditCtrlDeleteSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlDeleteSelection"), typeof(_GuiEditCtrlDeleteSelection));
            }

            _GuiEditCtrlDeleteSelectionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlMoveSelection(IntPtr ctrl, int deltaX, int deltaY);
         private static _GuiEditCtrlMoveSelection _GuiEditCtrlMoveSelectionFunc;
         internal static void GuiEditCtrlMoveSelection(IntPtr ctrl, int deltaX, int deltaY)
         {
            if (_GuiEditCtrlMoveSelectionFunc == null)
            {
               _GuiEditCtrlMoveSelectionFunc =
                  (_GuiEditCtrlMoveSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlMoveSelection"), typeof(_GuiEditCtrlMoveSelection));
            }

            _GuiEditCtrlMoveSelectionFunc(ctrl, deltaX, deltaY);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlSaveSelection(IntPtr ctrl, string fileName);
         private static _GuiEditCtrlSaveSelection _GuiEditCtrlSaveSelectionFunc;
         internal static void GuiEditCtrlSaveSelection(IntPtr ctrl, string fileName)
         {
            if (_GuiEditCtrlSaveSelectionFunc == null)
            {
               _GuiEditCtrlSaveSelectionFunc =
                  (_GuiEditCtrlSaveSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlSaveSelection"), typeof(_GuiEditCtrlSaveSelection));
            }

            _GuiEditCtrlSaveSelectionFunc(ctrl, fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlLoadSelection(IntPtr ctrl, string fileName);
         private static _GuiEditCtrlLoadSelection _GuiEditCtrlLoadSelectionFunc;
         internal static void GuiEditCtrlLoadSelection(IntPtr ctrl, string fileName)
         {
            if (_GuiEditCtrlLoadSelectionFunc == null)
            {
               _GuiEditCtrlLoadSelectionFunc =
                  (_GuiEditCtrlLoadSelection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlLoadSelection"), typeof(_GuiEditCtrlLoadSelection));
            }

            _GuiEditCtrlLoadSelectionFunc(ctrl, fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlSelectAll(IntPtr ctrl);
         private static _GuiEditCtrlSelectAll _GuiEditCtrlSelectAllFunc;
         internal static void GuiEditCtrlSelectAll(IntPtr ctrl)
         {
            if (_GuiEditCtrlSelectAllFunc == null)
            {
               _GuiEditCtrlSelectAllFunc =
                  (_GuiEditCtrlSelectAll)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlSelectAll"), typeof(_GuiEditCtrlSelectAll));
            }

            _GuiEditCtrlSelectAllFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiEditCtrlGetSelected(IntPtr ctrl);
         private static _GuiEditCtrlGetSelected _GuiEditCtrlGetSelectedFunc;
         internal static IntPtr GuiEditCtrlGetSelected(IntPtr ctrl)
         {
            if (_GuiEditCtrlGetSelectedFunc == null)
            {
               _GuiEditCtrlGetSelectedFunc =
                  (_GuiEditCtrlGetSelected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlGetSelected"), typeof(_GuiEditCtrlGetSelected));
            }

            return _GuiEditCtrlGetSelectedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiEditCtrlGetTrash(IntPtr ctrl);
         private static _GuiEditCtrlGetTrash _GuiEditCtrlGetTrashFunc;
         internal static IntPtr GuiEditCtrlGetTrash(IntPtr ctrl)
         {
            if (_GuiEditCtrlGetTrashFunc == null)
            {
               _GuiEditCtrlGetTrashFunc =
                  (_GuiEditCtrlGetTrash)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlGetTrash"), typeof(_GuiEditCtrlGetTrash));
            }

            return _GuiEditCtrlGetTrashFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiEditCtrlGetUndoManager(IntPtr ctrl);
         private static _GuiEditCtrlGetUndoManager _GuiEditCtrlGetUndoManagerFunc;
         internal static IntPtr GuiEditCtrlGetUndoManager(IntPtr ctrl)
         {
            if (_GuiEditCtrlGetUndoManagerFunc == null)
            {
               _GuiEditCtrlGetUndoManagerFunc =
                  (_GuiEditCtrlGetUndoManager)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlGetUndoManager"), typeof(_GuiEditCtrlGetUndoManager));
            }

            return _GuiEditCtrlGetUndoManagerFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiEditCtrlSetSnapToGrid(IntPtr ctrl, uint gridSize);
         private static _GuiEditCtrlSetSnapToGrid _GuiEditCtrlSetSnapToGridFunc;
         internal static void GuiEditCtrlSetSnapToGrid(IntPtr ctrl, uint gridSize)
         {
            if (_GuiEditCtrlSetSnapToGridFunc == null)
            {
               _GuiEditCtrlSetSnapToGridFunc =
                  (_GuiEditCtrlSetSnapToGrid)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiEditCtrlSetSnapToGrid"), typeof(_GuiEditCtrlSetSnapToGrid));
            }

            _GuiEditCtrlSetSnapToGridFunc(ctrl, gridSize);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void SetRoot(GuiControl root)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlSetRoot(ObjectPtr->ObjPtr, root.ObjectPtr->ObjPtr);
      }

      public void AddNewCtrl(GuiControl root)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlAddNewCtrl(ObjectPtr->ObjPtr, root.ObjectPtr->ObjPtr);
      }

      public void AddSelection(int ctrlID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlAddSelection(ObjectPtr->ObjPtr, ctrlID);
      }

      public void RemoveSelection(int ctrlID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlRemoveSelection(ObjectPtr->ObjPtr, ctrlID);
      }

      public void ClearSelection()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlClearSelection(ObjectPtr->ObjPtr);
      }

      public void Select(GuiControl  selCtrl)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlSelect(ObjectPtr->ObjPtr, selCtrl.ObjectPtr->ObjPtr);
      }

      public void SetCurrentAddSet(GuiControl  selCtrl)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlSetCurrentAddSet(ObjectPtr->ObjPtr, selCtrl.ObjectPtr->ObjPtr);
      }

      public GuiControl GetCurrentAddSet()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new GuiControl(InternalUnsafeMethods.GuiEditCtrlGetCurrentAddSet(ObjectPtr->ObjPtr));
      }

      public void Toggle()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlToggle(ObjectPtr->ObjPtr);
      }

      public void Justify(int mode)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlJustify(ObjectPtr->ObjPtr, mode);
      }

      public void BringToFront()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlBringToFront(ObjectPtr->ObjPtr);
      }

      public void PushToBack()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlPushToBack(ObjectPtr->ObjPtr);
      }

      public void DeleteSelection()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlDeleteSelection(ObjectPtr->ObjPtr);
      }

      public void MoveSelection(int deltaX, int deltaY)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlMoveSelection(ObjectPtr->ObjPtr, deltaX, deltaY);
      }

      public void SaveSelection(string fileName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlSaveSelection(ObjectPtr->ObjPtr, fileName);
      }

      public void LoadSelection(string fileName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlLoadSelection(ObjectPtr->ObjPtr, fileName);
      }

      public void SelectAll()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlSelectAll(ObjectPtr->ObjPtr);
      }

      public SimSet GetSelected()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimSet(InternalUnsafeMethods.GuiEditCtrlGetSelected(ObjectPtr->ObjPtr));
      }

      public SimGroup GetTrash()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimGroup(InternalUnsafeMethods.GuiEditCtrlGetTrash(ObjectPtr->ObjPtr));
      }

      public UndoManager GetUndoManager()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new UndoManager(InternalUnsafeMethods.GuiEditCtrlGetUndoManager(ObjectPtr->ObjPtr));
      }

      public void SetSnapToGrid(uint gridSize)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiEditCtrlSetSnapToGrid(ObjectPtr->ObjPtr, gridSize);
      }
      
      #endregion

      
   }
}