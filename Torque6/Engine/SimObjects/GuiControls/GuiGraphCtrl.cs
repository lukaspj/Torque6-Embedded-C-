using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiGraphCtrl : GuiControl
   {
      
      public GuiGraphCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiGraphCtrlCreateInstance());
      }

      public GuiGraphCtrl(uint pId) : base(pId)
      {
      }

      public GuiGraphCtrl(string pName) : base(pName)
      {
      }

      public GuiGraphCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiGraphCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiGraphCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiGraphCtrlCreateInstance();
         private static _GuiGraphCtrlCreateInstance _GuiGraphCtrlCreateInstanceFunc;
         internal static IntPtr GuiGraphCtrlCreateInstance()
         {
            if (_GuiGraphCtrlCreateInstanceFunc == null)
            {
               _GuiGraphCtrlCreateInstanceFunc =
                  (_GuiGraphCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiGraphCtrlCreateInstance"), typeof(_GuiGraphCtrlCreateInstance));
            }

            return _GuiGraphCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiGraphCtrlAddDatum(IntPtr ctrl, int plotID, float v);
         private static _GuiGraphCtrlAddDatum _GuiGraphCtrlAddDatumFunc;
         internal static void GuiGraphCtrlAddDatum(IntPtr ctrl, int plotID, float v)
         {
            if (_GuiGraphCtrlAddDatumFunc == null)
            {
               _GuiGraphCtrlAddDatumFunc =
                  (_GuiGraphCtrlAddDatum)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiGraphCtrlAddDatum"), typeof(_GuiGraphCtrlAddDatum));
            }

            _GuiGraphCtrlAddDatumFunc(ctrl, plotID, v);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _GuiGraphCtrlGetDatum(IntPtr ctrl, int plotID, int samples);
         private static _GuiGraphCtrlGetDatum _GuiGraphCtrlGetDatumFunc;
         internal static float GuiGraphCtrlGetDatum(IntPtr ctrl, int plotID, int samples)
         {
            if (_GuiGraphCtrlGetDatumFunc == null)
            {
               _GuiGraphCtrlGetDatumFunc =
                  (_GuiGraphCtrlGetDatum)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiGraphCtrlGetDatum"), typeof(_GuiGraphCtrlGetDatum));
            }

            return _GuiGraphCtrlGetDatumFunc(ctrl, plotID, samples);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiGraphCtrlAddAutoPlot(IntPtr ctrl, int plotID, string variable, int update);
         private static _GuiGraphCtrlAddAutoPlot _GuiGraphCtrlAddAutoPlotFunc;
         internal static void GuiGraphCtrlAddAutoPlot(IntPtr ctrl, int plotID, string variable, int update)
         {
            if (_GuiGraphCtrlAddAutoPlotFunc == null)
            {
               _GuiGraphCtrlAddAutoPlotFunc =
                  (_GuiGraphCtrlAddAutoPlot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiGraphCtrlAddAutoPlot"), typeof(_GuiGraphCtrlAddAutoPlot));
            }

            _GuiGraphCtrlAddAutoPlotFunc(ctrl, plotID, variable, update);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiGraphCtrlRemoveAutoPlot(IntPtr ctrl, int plotID);
         private static _GuiGraphCtrlRemoveAutoPlot _GuiGraphCtrlRemoveAutoPlotFunc;
         internal static void GuiGraphCtrlRemoveAutoPlot(IntPtr ctrl, int plotID)
         {
            if (_GuiGraphCtrlRemoveAutoPlotFunc == null)
            {
               _GuiGraphCtrlRemoveAutoPlotFunc =
                  (_GuiGraphCtrlRemoveAutoPlot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiGraphCtrlRemoveAutoPlot"), typeof(_GuiGraphCtrlRemoveAutoPlot));
            }

            _GuiGraphCtrlRemoveAutoPlotFunc(ctrl, plotID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiGraphCtrlSetGraphType(IntPtr ctrl, int plotID, string graphType);
         private static _GuiGraphCtrlSetGraphType _GuiGraphCtrlSetGraphTypeFunc;
         internal static void GuiGraphCtrlSetGraphType(IntPtr ctrl, int plotID, string graphType)
         {
            if (_GuiGraphCtrlSetGraphTypeFunc == null)
            {
               _GuiGraphCtrlSetGraphTypeFunc =
                  (_GuiGraphCtrlSetGraphType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiGraphCtrlSetGraphType"), typeof(_GuiGraphCtrlSetGraphType));
            }

            _GuiGraphCtrlSetGraphTypeFunc(ctrl, plotID, graphType);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiGraphCtrlMatchScale(IntPtr ctrl, int argc, int[] argv);
         private static _GuiGraphCtrlMatchScale _GuiGraphCtrlMatchScaleFunc;
         internal static void GuiGraphCtrlMatchScale(IntPtr ctrl, int argc, int[] argv)
         {
            if (_GuiGraphCtrlMatchScaleFunc == null)
            {
               _GuiGraphCtrlMatchScaleFunc =
                  (_GuiGraphCtrlMatchScale)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiGraphCtrlMatchScale"), typeof(_GuiGraphCtrlMatchScale));
            }

            _GuiGraphCtrlMatchScaleFunc(ctrl, argc, argv);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void AddDatum(int plotID, float v)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiGraphCtrlAddDatum(ObjectPtr->ObjPtr, plotID, v);
      }

      public float GetDatum(int plotID, int samples)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiGraphCtrlGetDatum(ObjectPtr->ObjPtr, plotID, samples);
      }

      public void AddAutoPlot(int plotID, string variable, int update)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiGraphCtrlAddAutoPlot(ObjectPtr->ObjPtr, plotID, variable, update);
      }

      public void RemoveAutoPlot(int plotID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiGraphCtrlRemoveAutoPlot(ObjectPtr->ObjPtr, plotID);
      }

      public void SetGraphType(int plotID, string graphType)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiGraphCtrlSetGraphType(ObjectPtr->ObjPtr, plotID, graphType);
      }

      public void MatchScale(int argc, int[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiGraphCtrlMatchScale(ObjectPtr->ObjPtr, argc, argv);
      }
      
      #endregion

      
   }
}