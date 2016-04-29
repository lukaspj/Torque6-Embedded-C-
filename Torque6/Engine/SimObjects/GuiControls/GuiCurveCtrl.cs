using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiCurveCtrl : GuiControl
   {
      
      public GuiCurveCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiCurveCtrlCreateInstance());
      }

      public GuiCurveCtrl(uint pId) : base(pId)
      {
      }

      public GuiCurveCtrl(string pName) : base(pName)
      {
      }

      public GuiCurveCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiCurveCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiCurveCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlGetStart(IntPtr ctrl, out Point2I outPos);
         private static _GuiCurveCtrlGetStart _GuiCurveCtrlGetStartFunc;
         internal static void GuiCurveCtrlGetStart(IntPtr ctrl, out Point2I outPos)
         {
            if (_GuiCurveCtrlGetStartFunc == null)
            {
               _GuiCurveCtrlGetStartFunc =
                  (_GuiCurveCtrlGetStart)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlGetStart"), typeof(_GuiCurveCtrlGetStart));
            }

            _GuiCurveCtrlGetStartFunc(ctrl, out outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlSetStart(IntPtr ctrl, Point2I pos);
         private static _GuiCurveCtrlSetStart _GuiCurveCtrlSetStartFunc;
         internal static void GuiCurveCtrlSetStart(IntPtr ctrl, Point2I pos)
         {
            if (_GuiCurveCtrlSetStartFunc == null)
            {
               _GuiCurveCtrlSetStartFunc =
                  (_GuiCurveCtrlSetStart)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlSetStart"), typeof(_GuiCurveCtrlSetStart));
            }

            _GuiCurveCtrlSetStartFunc(ctrl, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlGetEnd(IntPtr ctrl, out Point2I outPos);
         private static _GuiCurveCtrlGetEnd _GuiCurveCtrlGetEndFunc;
         internal static void GuiCurveCtrlGetEnd(IntPtr ctrl, out Point2I outPos)
         {
            if (_GuiCurveCtrlGetEndFunc == null)
            {
               _GuiCurveCtrlGetEndFunc =
                  (_GuiCurveCtrlGetEnd)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlGetEnd"), typeof(_GuiCurveCtrlGetEnd));
            }

            _GuiCurveCtrlGetEndFunc(ctrl, out outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlSetEnd(IntPtr ctrl, Point2I pos);
         private static _GuiCurveCtrlSetEnd _GuiCurveCtrlSetEndFunc;
         internal static void GuiCurveCtrlSetEnd(IntPtr ctrl, Point2I pos)
         {
            if (_GuiCurveCtrlSetEndFunc == null)
            {
               _GuiCurveCtrlSetEndFunc =
                  (_GuiCurveCtrlSetEnd)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlSetEnd"), typeof(_GuiCurveCtrlSetEnd));
            }

            _GuiCurveCtrlSetEndFunc(ctrl, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlGetControlA(IntPtr ctrl, out Point2I outPos);
         private static _GuiCurveCtrlGetControlA _GuiCurveCtrlGetControlAFunc;
         internal static void GuiCurveCtrlGetControlA(IntPtr ctrl, out Point2I outPos)
         {
            if (_GuiCurveCtrlGetControlAFunc == null)
            {
               _GuiCurveCtrlGetControlAFunc =
                  (_GuiCurveCtrlGetControlA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlGetControlA"), typeof(_GuiCurveCtrlGetControlA));
            }

            _GuiCurveCtrlGetControlAFunc(ctrl, out outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlSetControlA(IntPtr ctrl, Point2I pos);
         private static _GuiCurveCtrlSetControlA _GuiCurveCtrlSetControlAFunc;
         internal static void GuiCurveCtrlSetControlA(IntPtr ctrl, Point2I pos)
         {
            if (_GuiCurveCtrlSetControlAFunc == null)
            {
               _GuiCurveCtrlSetControlAFunc =
                  (_GuiCurveCtrlSetControlA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlSetControlA"), typeof(_GuiCurveCtrlSetControlA));
            }

            _GuiCurveCtrlSetControlAFunc(ctrl, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlGetControlB(IntPtr ctrl, out Point2I outPos);
         private static _GuiCurveCtrlGetControlB _GuiCurveCtrlGetControlBFunc;
         internal static void GuiCurveCtrlGetControlB(IntPtr ctrl, out Point2I outPos)
         {
            if (_GuiCurveCtrlGetControlBFunc == null)
            {
               _GuiCurveCtrlGetControlBFunc =
                  (_GuiCurveCtrlGetControlB)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlGetControlB"), typeof(_GuiCurveCtrlGetControlB));
            }

            _GuiCurveCtrlGetControlBFunc(ctrl, out outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlSetControlB(IntPtr ctrl, Point2I pos);
         private static _GuiCurveCtrlSetControlB _GuiCurveCtrlSetControlBFunc;
         internal static void GuiCurveCtrlSetControlB(IntPtr ctrl, Point2I pos)
         {
            if (_GuiCurveCtrlSetControlBFunc == null)
            {
               _GuiCurveCtrlSetControlBFunc =
                  (_GuiCurveCtrlSetControlB)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlSetControlB"), typeof(_GuiCurveCtrlSetControlB));
            }

            _GuiCurveCtrlSetControlBFunc(ctrl, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlGetColor(IntPtr ctrl, out Color outCol);
         private static _GuiCurveCtrlGetColor _GuiCurveCtrlGetColorFunc;
         internal static void GuiCurveCtrlGetColor(IntPtr ctrl, out Color outCol)
         {
            if (_GuiCurveCtrlGetColorFunc == null)
            {
               _GuiCurveCtrlGetColorFunc =
                  (_GuiCurveCtrlGetColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlGetColor"), typeof(_GuiCurveCtrlGetColor));
            }

            _GuiCurveCtrlGetColorFunc(ctrl, out outCol);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlSetColor(IntPtr ctrl, Color color);
         private static _GuiCurveCtrlSetColor _GuiCurveCtrlSetColorFunc;
         internal static void GuiCurveCtrlSetColor(IntPtr ctrl, Color color)
         {
            if (_GuiCurveCtrlSetColorFunc == null)
            {
               _GuiCurveCtrlSetColorFunc =
                  (_GuiCurveCtrlSetColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlSetColor"), typeof(_GuiCurveCtrlSetColor));
            }

            _GuiCurveCtrlSetColorFunc(ctrl, color);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _GuiCurveCtrlGetThickness(IntPtr ctrl);
         private static _GuiCurveCtrlGetThickness _GuiCurveCtrlGetThicknessFunc;
         internal static float GuiCurveCtrlGetThickness(IntPtr ctrl)
         {
            if (_GuiCurveCtrlGetThicknessFunc == null)
            {
               _GuiCurveCtrlGetThicknessFunc =
                  (_GuiCurveCtrlGetThickness)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlGetThickness"), typeof(_GuiCurveCtrlGetThickness));
            }

            return _GuiCurveCtrlGetThicknessFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCurveCtrlSetThickness(IntPtr ctrl, float thickness);
         private static _GuiCurveCtrlSetThickness _GuiCurveCtrlSetThicknessFunc;
         internal static void GuiCurveCtrlSetThickness(IntPtr ctrl, float thickness)
         {
            if (_GuiCurveCtrlSetThicknessFunc == null)
            {
               _GuiCurveCtrlSetThicknessFunc =
                  (_GuiCurveCtrlSetThickness)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlSetThickness"), typeof(_GuiCurveCtrlSetThickness));
            }

            _GuiCurveCtrlSetThicknessFunc(ctrl, thickness);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCurveCtrlCreateInstance();
         private static _GuiCurveCtrlCreateInstance _GuiCurveCtrlCreateInstanceFunc;
         internal static IntPtr GuiCurveCtrlCreateInstance()
         {
            if (_GuiCurveCtrlCreateInstanceFunc == null)
            {
               _GuiCurveCtrlCreateInstanceFunc =
                  (_GuiCurveCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCurveCtrlCreateInstance"), typeof(_GuiCurveCtrlCreateInstance));
            }

            return _GuiCurveCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public Point2I Start
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiCurveCtrlGetStart(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCurveCtrlSetStart(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I End
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiCurveCtrlGetEnd(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCurveCtrlSetEnd(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I ControlA
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiCurveCtrlGetControlA(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCurveCtrlSetControlA(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I ControlB
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiCurveCtrlGetControlB(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCurveCtrlSetControlB(ObjectPtr->ObjPtr, value);
         }
      }
      public Color Color
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiCurveCtrlGetColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCurveCtrlSetColor(ObjectPtr->ObjPtr, value);
         }
      }
      public float Thickness
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiCurveCtrlGetThickness(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCurveCtrlSetThickness(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}