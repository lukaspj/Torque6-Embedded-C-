using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiControlProfile : SimObject
   {
      
      public GuiControlProfile()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiControlProfileCreateInstance());
      }

      public GuiControlProfile(uint pId) : base(pId)
      {
      }

      public GuiControlProfile(string pName) : base(pName)
      {
      }

      public GuiControlProfile(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiControlProfile(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiControlProfile(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlProfileGetTab(IntPtr controlProfile);
         private static _GuiControlProfileGetTab _GuiControlProfileGetTabFunc;
         internal static bool GuiControlProfileGetTab(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetTabFunc == null)
            {
               _GuiControlProfileGetTabFunc =
                  (_GuiControlProfileGetTab)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetTab"), typeof(_GuiControlProfileGetTab));
            }

            return _GuiControlProfileGetTabFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetTab(IntPtr controlProfile, bool value);
         private static _GuiControlProfileSetTab _GuiControlProfileSetTabFunc;
         internal static void GuiControlProfileSetTab(IntPtr controlProfile, bool value)
         {
            if (_GuiControlProfileSetTabFunc == null)
            {
               _GuiControlProfileSetTabFunc =
                  (_GuiControlProfileSetTab)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetTab"), typeof(_GuiControlProfileSetTab));
            }

            _GuiControlProfileSetTabFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlProfileGetCanKeyFocus(IntPtr controlProfile);
         private static _GuiControlProfileGetCanKeyFocus _GuiControlProfileGetCanKeyFocusFunc;
         internal static bool GuiControlProfileGetCanKeyFocus(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetCanKeyFocusFunc == null)
            {
               _GuiControlProfileGetCanKeyFocusFunc =
                  (_GuiControlProfileGetCanKeyFocus)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetCanKeyFocus"), typeof(_GuiControlProfileGetCanKeyFocus));
            }

            return _GuiControlProfileGetCanKeyFocusFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetCanKeyFocus(IntPtr controlProfile, bool value);
         private static _GuiControlProfileSetCanKeyFocus _GuiControlProfileSetCanKeyFocusFunc;
         internal static void GuiControlProfileSetCanKeyFocus(IntPtr controlProfile, bool value)
         {
            if (_GuiControlProfileSetCanKeyFocusFunc == null)
            {
               _GuiControlProfileSetCanKeyFocusFunc =
                  (_GuiControlProfileSetCanKeyFocus)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetCanKeyFocus"), typeof(_GuiControlProfileSetCanKeyFocus));
            }

            _GuiControlProfileSetCanKeyFocusFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlProfileGetMouseOverSelected(IntPtr controlProfile);
         private static _GuiControlProfileGetMouseOverSelected _GuiControlProfileGetMouseOverSelectedFunc;
         internal static bool GuiControlProfileGetMouseOverSelected(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetMouseOverSelectedFunc == null)
            {
               _GuiControlProfileGetMouseOverSelectedFunc =
                  (_GuiControlProfileGetMouseOverSelected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetMouseOverSelected"), typeof(_GuiControlProfileGetMouseOverSelected));
            }

            return _GuiControlProfileGetMouseOverSelectedFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetMouseOverSelected(IntPtr controlProfile, bool value);
         private static _GuiControlProfileSetMouseOverSelected _GuiControlProfileSetMouseOverSelectedFunc;
         internal static void GuiControlProfileSetMouseOverSelected(IntPtr controlProfile, bool value)
         {
            if (_GuiControlProfileSetMouseOverSelectedFunc == null)
            {
               _GuiControlProfileSetMouseOverSelectedFunc =
                  (_GuiControlProfileSetMouseOverSelected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetMouseOverSelected"), typeof(_GuiControlProfileSetMouseOverSelected));
            }

            _GuiControlProfileSetMouseOverSelectedFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlProfileGetModal(IntPtr controlProfile);
         private static _GuiControlProfileGetModal _GuiControlProfileGetModalFunc;
         internal static bool GuiControlProfileGetModal(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetModalFunc == null)
            {
               _GuiControlProfileGetModalFunc =
                  (_GuiControlProfileGetModal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetModal"), typeof(_GuiControlProfileGetModal));
            }

            return _GuiControlProfileGetModalFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetModal(IntPtr controlProfile, bool value);
         private static _GuiControlProfileSetModal _GuiControlProfileSetModalFunc;
         internal static void GuiControlProfileSetModal(IntPtr controlProfile, bool value)
         {
            if (_GuiControlProfileSetModalFunc == null)
            {
               _GuiControlProfileSetModalFunc =
                  (_GuiControlProfileSetModal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetModal"), typeof(_GuiControlProfileSetModal));
            }

            _GuiControlProfileSetModalFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlProfileGetOpaque(IntPtr controlProfile);
         private static _GuiControlProfileGetOpaque _GuiControlProfileGetOpaqueFunc;
         internal static bool GuiControlProfileGetOpaque(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetOpaqueFunc == null)
            {
               _GuiControlProfileGetOpaqueFunc =
                  (_GuiControlProfileGetOpaque)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetOpaque"), typeof(_GuiControlProfileGetOpaque));
            }

            return _GuiControlProfileGetOpaqueFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetOpaque(IntPtr controlProfile, bool value);
         private static _GuiControlProfileSetOpaque _GuiControlProfileSetOpaqueFunc;
         internal static void GuiControlProfileSetOpaque(IntPtr controlProfile, bool value)
         {
            if (_GuiControlProfileSetOpaqueFunc == null)
            {
               _GuiControlProfileSetOpaqueFunc =
                  (_GuiControlProfileSetOpaque)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetOpaque"), typeof(_GuiControlProfileSetOpaque));
            }

            _GuiControlProfileSetOpaqueFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFillColor(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetFillColor _GuiControlProfileGetFillColorFunc;
         internal static void GuiControlProfileGetFillColor(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetFillColorFunc == null)
            {
               _GuiControlProfileGetFillColorFunc =
                  (_GuiControlProfileGetFillColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFillColor"), typeof(_GuiControlProfileGetFillColor));
            }

            _GuiControlProfileGetFillColorFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFillColor(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetFillColor _GuiControlProfileSetFillColorFunc;
         internal static void GuiControlProfileSetFillColor(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetFillColorFunc == null)
            {
               _GuiControlProfileSetFillColorFunc =
                  (_GuiControlProfileSetFillColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFillColor"), typeof(_GuiControlProfileSetFillColor));
            }

            _GuiControlProfileSetFillColorFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFillColorHL(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetFillColorHL _GuiControlProfileGetFillColorHLFunc;
         internal static void GuiControlProfileGetFillColorHL(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetFillColorHLFunc == null)
            {
               _GuiControlProfileGetFillColorHLFunc =
                  (_GuiControlProfileGetFillColorHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFillColorHL"), typeof(_GuiControlProfileGetFillColorHL));
            }

            _GuiControlProfileGetFillColorHLFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFillColorHL(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetFillColorHL _GuiControlProfileSetFillColorHLFunc;
         internal static void GuiControlProfileSetFillColorHL(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetFillColorHLFunc == null)
            {
               _GuiControlProfileSetFillColorHLFunc =
                  (_GuiControlProfileSetFillColorHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFillColorHL"), typeof(_GuiControlProfileSetFillColorHL));
            }

            _GuiControlProfileSetFillColorHLFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFillColorNA(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetFillColorNA _GuiControlProfileGetFillColorNAFunc;
         internal static void GuiControlProfileGetFillColorNA(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetFillColorNAFunc == null)
            {
               _GuiControlProfileGetFillColorNAFunc =
                  (_GuiControlProfileGetFillColorNA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFillColorNA"), typeof(_GuiControlProfileGetFillColorNA));
            }

            _GuiControlProfileGetFillColorNAFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFillColorNA(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetFillColorNA _GuiControlProfileSetFillColorNAFunc;
         internal static void GuiControlProfileSetFillColorNA(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetFillColorNAFunc == null)
            {
               _GuiControlProfileSetFillColorNAFunc =
                  (_GuiControlProfileSetFillColorNA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFillColorNA"), typeof(_GuiControlProfileSetFillColorNA));
            }

            _GuiControlProfileSetFillColorNAFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlProfileGetBorder(IntPtr controlProfile);
         private static _GuiControlProfileGetBorder _GuiControlProfileGetBorderFunc;
         internal static int GuiControlProfileGetBorder(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetBorderFunc == null)
            {
               _GuiControlProfileGetBorderFunc =
                  (_GuiControlProfileGetBorder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetBorder"), typeof(_GuiControlProfileGetBorder));
            }

            return _GuiControlProfileGetBorderFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetBorder(IntPtr controlProfile, int value);
         private static _GuiControlProfileSetBorder _GuiControlProfileSetBorderFunc;
         internal static void GuiControlProfileSetBorder(IntPtr controlProfile, int value)
         {
            if (_GuiControlProfileSetBorderFunc == null)
            {
               _GuiControlProfileSetBorderFunc =
                  (_GuiControlProfileSetBorder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetBorder"), typeof(_GuiControlProfileSetBorder));
            }

            _GuiControlProfileSetBorderFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlProfileGetBorderThickness(IntPtr controlProfile);
         private static _GuiControlProfileGetBorderThickness _GuiControlProfileGetBorderThicknessFunc;
         internal static int GuiControlProfileGetBorderThickness(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetBorderThicknessFunc == null)
            {
               _GuiControlProfileGetBorderThicknessFunc =
                  (_GuiControlProfileGetBorderThickness)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetBorderThickness"), typeof(_GuiControlProfileGetBorderThickness));
            }

            return _GuiControlProfileGetBorderThicknessFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetBorderThickness(IntPtr controlProfile, int value);
         private static _GuiControlProfileSetBorderThickness _GuiControlProfileSetBorderThicknessFunc;
         internal static void GuiControlProfileSetBorderThickness(IntPtr controlProfile, int value)
         {
            if (_GuiControlProfileSetBorderThicknessFunc == null)
            {
               _GuiControlProfileSetBorderThicknessFunc =
                  (_GuiControlProfileSetBorderThickness)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetBorderThickness"), typeof(_GuiControlProfileSetBorderThickness));
            }

            _GuiControlProfileSetBorderThicknessFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetBorderColor(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetBorderColor _GuiControlProfileGetBorderColorFunc;
         internal static void GuiControlProfileGetBorderColor(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetBorderColorFunc == null)
            {
               _GuiControlProfileGetBorderColorFunc =
                  (_GuiControlProfileGetBorderColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetBorderColor"), typeof(_GuiControlProfileGetBorderColor));
            }

            _GuiControlProfileGetBorderColorFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetBorderColor(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetBorderColor _GuiControlProfileSetBorderColorFunc;
         internal static void GuiControlProfileSetBorderColor(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetBorderColorFunc == null)
            {
               _GuiControlProfileSetBorderColorFunc =
                  (_GuiControlProfileSetBorderColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetBorderColor"), typeof(_GuiControlProfileSetBorderColor));
            }

            _GuiControlProfileSetBorderColorFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetBorderColorHL(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetBorderColorHL _GuiControlProfileGetBorderColorHLFunc;
         internal static void GuiControlProfileGetBorderColorHL(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetBorderColorHLFunc == null)
            {
               _GuiControlProfileGetBorderColorHLFunc =
                  (_GuiControlProfileGetBorderColorHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetBorderColorHL"), typeof(_GuiControlProfileGetBorderColorHL));
            }

            _GuiControlProfileGetBorderColorHLFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetBorderColorHL(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetBorderColorHL _GuiControlProfileSetBorderColorHLFunc;
         internal static void GuiControlProfileSetBorderColorHL(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetBorderColorHLFunc == null)
            {
               _GuiControlProfileSetBorderColorHLFunc =
                  (_GuiControlProfileSetBorderColorHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetBorderColorHL"), typeof(_GuiControlProfileSetBorderColorHL));
            }

            _GuiControlProfileSetBorderColorHLFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetBorderColorNA(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetBorderColorNA _GuiControlProfileGetBorderColorNAFunc;
         internal static void GuiControlProfileGetBorderColorNA(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetBorderColorNAFunc == null)
            {
               _GuiControlProfileGetBorderColorNAFunc =
                  (_GuiControlProfileGetBorderColorNA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetBorderColorNA"), typeof(_GuiControlProfileGetBorderColorNA));
            }

            _GuiControlProfileGetBorderColorNAFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetBorderColorNA(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetBorderColorNA _GuiControlProfileSetBorderColorNAFunc;
         internal static void GuiControlProfileSetBorderColorNA(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetBorderColorNAFunc == null)
            {
               _GuiControlProfileSetBorderColorNAFunc =
                  (_GuiControlProfileSetBorderColorNA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetBorderColorNA"), typeof(_GuiControlProfileSetBorderColorNA));
            }

            _GuiControlProfileSetBorderColorNAFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetBevelColorHL(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetBevelColorHL _GuiControlProfileGetBevelColorHLFunc;
         internal static void GuiControlProfileGetBevelColorHL(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetBevelColorHLFunc == null)
            {
               _GuiControlProfileGetBevelColorHLFunc =
                  (_GuiControlProfileGetBevelColorHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetBevelColorHL"), typeof(_GuiControlProfileGetBevelColorHL));
            }

            _GuiControlProfileGetBevelColorHLFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetBevelColorHL(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetBevelColorHL _GuiControlProfileSetBevelColorHLFunc;
         internal static void GuiControlProfileSetBevelColorHL(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetBevelColorHLFunc == null)
            {
               _GuiControlProfileSetBevelColorHLFunc =
                  (_GuiControlProfileSetBevelColorHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetBevelColorHL"), typeof(_GuiControlProfileSetBevelColorHL));
            }

            _GuiControlProfileSetBevelColorHLFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetBevelColorLL(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetBevelColorLL _GuiControlProfileGetBevelColorLLFunc;
         internal static void GuiControlProfileGetBevelColorLL(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetBevelColorLLFunc == null)
            {
               _GuiControlProfileGetBevelColorLLFunc =
                  (_GuiControlProfileGetBevelColorLL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetBevelColorLL"), typeof(_GuiControlProfileGetBevelColorLL));
            }

            _GuiControlProfileGetBevelColorLLFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetBevelColorLL(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetBevelColorLL _GuiControlProfileSetBevelColorLLFunc;
         internal static void GuiControlProfileSetBevelColorLL(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetBevelColorLLFunc == null)
            {
               _GuiControlProfileSetBevelColorLLFunc =
                  (_GuiControlProfileSetBevelColorLL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetBevelColorLL"), typeof(_GuiControlProfileSetBevelColorLL));
            }

            _GuiControlProfileSetBevelColorLLFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlProfileGetFontType(IntPtr controlProfile);
         private static _GuiControlProfileGetFontType _GuiControlProfileGetFontTypeFunc;
         internal static IntPtr GuiControlProfileGetFontType(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetFontTypeFunc == null)
            {
               _GuiControlProfileGetFontTypeFunc =
                  (_GuiControlProfileGetFontType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontType"), typeof(_GuiControlProfileGetFontType));
            }

            return _GuiControlProfileGetFontTypeFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontType(IntPtr controlProfile, string value);
         private static _GuiControlProfileSetFontType _GuiControlProfileSetFontTypeFunc;
         internal static void GuiControlProfileSetFontType(IntPtr controlProfile, string value)
         {
            if (_GuiControlProfileSetFontTypeFunc == null)
            {
               _GuiControlProfileSetFontTypeFunc =
                  (_GuiControlProfileSetFontType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontType"), typeof(_GuiControlProfileSetFontType));
            }

            _GuiControlProfileSetFontTypeFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlProfileGetFontSize(IntPtr controlProfile);
         private static _GuiControlProfileGetFontSize _GuiControlProfileGetFontSizeFunc;
         internal static int GuiControlProfileGetFontSize(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetFontSizeFunc == null)
            {
               _GuiControlProfileGetFontSizeFunc =
                  (_GuiControlProfileGetFontSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontSize"), typeof(_GuiControlProfileGetFontSize));
            }

            return _GuiControlProfileGetFontSizeFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontSize(IntPtr controlProfile, int value);
         private static _GuiControlProfileSetFontSize _GuiControlProfileSetFontSizeFunc;
         internal static void GuiControlProfileSetFontSize(IntPtr controlProfile, int value)
         {
            if (_GuiControlProfileSetFontSizeFunc == null)
            {
               _GuiControlProfileSetFontSizeFunc =
                  (_GuiControlProfileSetFontSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontSize"), typeof(_GuiControlProfileSetFontSize));
            }

            _GuiControlProfileSetFontSizeFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlProfileGetFontCharset(IntPtr controlProfile);
         private static _GuiControlProfileGetFontCharset _GuiControlProfileGetFontCharsetFunc;
         internal static int GuiControlProfileGetFontCharset(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetFontCharsetFunc == null)
            {
               _GuiControlProfileGetFontCharsetFunc =
                  (_GuiControlProfileGetFontCharset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontCharset"), typeof(_GuiControlProfileGetFontCharset));
            }

            return _GuiControlProfileGetFontCharsetFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontCharset(IntPtr controlProfile, int value);
         private static _GuiControlProfileSetFontCharset _GuiControlProfileSetFontCharsetFunc;
         internal static void GuiControlProfileSetFontCharset(IntPtr controlProfile, int value)
         {
            if (_GuiControlProfileSetFontCharsetFunc == null)
            {
               _GuiControlProfileSetFontCharsetFunc =
                  (_GuiControlProfileSetFontCharset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontCharset"), typeof(_GuiControlProfileSetFontCharset));
            }

            _GuiControlProfileSetFontCharsetFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFontColors(IntPtr controlProfile, int index, out Color outColor);
         private static _GuiControlProfileGetFontColors _GuiControlProfileGetFontColorsFunc;
         internal static void GuiControlProfileGetFontColors(IntPtr controlProfile, int index, out Color outColor)
         {
            if (_GuiControlProfileGetFontColorsFunc == null)
            {
               _GuiControlProfileGetFontColorsFunc =
                  (_GuiControlProfileGetFontColors)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontColors"), typeof(_GuiControlProfileGetFontColors));
            }

            _GuiControlProfileGetFontColorsFunc(controlProfile, index, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontColors(IntPtr controlProfile, int index, Color value);
         private static _GuiControlProfileSetFontColors _GuiControlProfileSetFontColorsFunc;
         internal static void GuiControlProfileSetFontColors(IntPtr controlProfile, int index, Color value)
         {
            if (_GuiControlProfileSetFontColorsFunc == null)
            {
               _GuiControlProfileSetFontColorsFunc =
                  (_GuiControlProfileSetFontColors)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontColors"), typeof(_GuiControlProfileSetFontColors));
            }

            _GuiControlProfileSetFontColorsFunc(controlProfile, index, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFontColor(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetFontColor _GuiControlProfileGetFontColorFunc;
         internal static void GuiControlProfileGetFontColor(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetFontColorFunc == null)
            {
               _GuiControlProfileGetFontColorFunc =
                  (_GuiControlProfileGetFontColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontColor"), typeof(_GuiControlProfileGetFontColor));
            }

            _GuiControlProfileGetFontColorFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontColor(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetFontColor _GuiControlProfileSetFontColorFunc;
         internal static void GuiControlProfileSetFontColor(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetFontColorFunc == null)
            {
               _GuiControlProfileSetFontColorFunc =
                  (_GuiControlProfileSetFontColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontColor"), typeof(_GuiControlProfileSetFontColor));
            }

            _GuiControlProfileSetFontColorFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFontColorHL(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetFontColorHL _GuiControlProfileGetFontColorHLFunc;
         internal static void GuiControlProfileGetFontColorHL(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetFontColorHLFunc == null)
            {
               _GuiControlProfileGetFontColorHLFunc =
                  (_GuiControlProfileGetFontColorHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontColorHL"), typeof(_GuiControlProfileGetFontColorHL));
            }

            _GuiControlProfileGetFontColorHLFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontColorHL(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetFontColorHL _GuiControlProfileSetFontColorHLFunc;
         internal static void GuiControlProfileSetFontColorHL(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetFontColorHLFunc == null)
            {
               _GuiControlProfileSetFontColorHLFunc =
                  (_GuiControlProfileSetFontColorHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontColorHL"), typeof(_GuiControlProfileSetFontColorHL));
            }

            _GuiControlProfileSetFontColorHLFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFontColorNA(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetFontColorNA _GuiControlProfileGetFontColorNAFunc;
         internal static void GuiControlProfileGetFontColorNA(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetFontColorNAFunc == null)
            {
               _GuiControlProfileGetFontColorNAFunc =
                  (_GuiControlProfileGetFontColorNA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontColorNA"), typeof(_GuiControlProfileGetFontColorNA));
            }

            _GuiControlProfileGetFontColorNAFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontColorNA(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetFontColorNA _GuiControlProfileSetFontColorNAFunc;
         internal static void GuiControlProfileSetFontColorNA(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetFontColorNAFunc == null)
            {
               _GuiControlProfileSetFontColorNAFunc =
                  (_GuiControlProfileSetFontColorNA)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontColorNA"), typeof(_GuiControlProfileSetFontColorNA));
            }

            _GuiControlProfileSetFontColorNAFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFontColorSEL(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetFontColorSEL _GuiControlProfileGetFontColorSELFunc;
         internal static void GuiControlProfileGetFontColorSEL(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetFontColorSELFunc == null)
            {
               _GuiControlProfileGetFontColorSELFunc =
                  (_GuiControlProfileGetFontColorSEL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontColorSEL"), typeof(_GuiControlProfileGetFontColorSEL));
            }

            _GuiControlProfileGetFontColorSELFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontColorSEL(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetFontColorSEL _GuiControlProfileSetFontColorSELFunc;
         internal static void GuiControlProfileSetFontColorSEL(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetFontColorSELFunc == null)
            {
               _GuiControlProfileSetFontColorSELFunc =
                  (_GuiControlProfileSetFontColorSEL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontColorSEL"), typeof(_GuiControlProfileSetFontColorSEL));
            }

            _GuiControlProfileSetFontColorSELFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFontColorLink(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetFontColorLink _GuiControlProfileGetFontColorLinkFunc;
         internal static void GuiControlProfileGetFontColorLink(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetFontColorLinkFunc == null)
            {
               _GuiControlProfileGetFontColorLinkFunc =
                  (_GuiControlProfileGetFontColorLink)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontColorLink"), typeof(_GuiControlProfileGetFontColorLink));
            }

            _GuiControlProfileGetFontColorLinkFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontColorLink(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetFontColorLink _GuiControlProfileSetFontColorLinkFunc;
         internal static void GuiControlProfileSetFontColorLink(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetFontColorLinkFunc == null)
            {
               _GuiControlProfileSetFontColorLinkFunc =
                  (_GuiControlProfileSetFontColorLink)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontColorLink"), typeof(_GuiControlProfileSetFontColorLink));
            }

            _GuiControlProfileSetFontColorLinkFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetFontColorLinkHL(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetFontColorLinkHL _GuiControlProfileGetFontColorLinkHLFunc;
         internal static void GuiControlProfileGetFontColorLinkHL(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetFontColorLinkHLFunc == null)
            {
               _GuiControlProfileGetFontColorLinkHLFunc =
                  (_GuiControlProfileGetFontColorLinkHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetFontColorLinkHL"), typeof(_GuiControlProfileGetFontColorLinkHL));
            }

            _GuiControlProfileGetFontColorLinkHLFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetFontColorLinkHL(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetFontColorLinkHL _GuiControlProfileSetFontColorLinkHLFunc;
         internal static void GuiControlProfileSetFontColorLinkHL(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetFontColorLinkHLFunc == null)
            {
               _GuiControlProfileSetFontColorLinkHLFunc =
                  (_GuiControlProfileSetFontColorLinkHL)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetFontColorLinkHL"), typeof(_GuiControlProfileSetFontColorLinkHL));
            }

            _GuiControlProfileSetFontColorLinkHLFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlProfileGetJustify(IntPtr controlProfile);
         private static _GuiControlProfileGetJustify _GuiControlProfileGetJustifyFunc;
         internal static int GuiControlProfileGetJustify(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetJustifyFunc == null)
            {
               _GuiControlProfileGetJustifyFunc =
                  (_GuiControlProfileGetJustify)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetJustify"), typeof(_GuiControlProfileGetJustify));
            }

            return _GuiControlProfileGetJustifyFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetJustify(IntPtr controlProfile, int value);
         private static _GuiControlProfileSetJustify _GuiControlProfileSetJustifyFunc;
         internal static void GuiControlProfileSetJustify(IntPtr controlProfile, int value)
         {
            if (_GuiControlProfileSetJustifyFunc == null)
            {
               _GuiControlProfileSetJustifyFunc =
                  (_GuiControlProfileSetJustify)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetJustify"), typeof(_GuiControlProfileSetJustify));
            }

            _GuiControlProfileSetJustifyFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate Point2I _GuiControlProfileGetTextOffset(IntPtr controlProfile);
         private static _GuiControlProfileGetTextOffset _GuiControlProfileGetTextOffsetFunc;
         internal static Point2I GuiControlProfileGetTextOffset(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetTextOffsetFunc == null)
            {
               _GuiControlProfileGetTextOffsetFunc =
                  (_GuiControlProfileGetTextOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetTextOffset"), typeof(_GuiControlProfileGetTextOffset));
            }

            return _GuiControlProfileGetTextOffsetFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetTextOffset(IntPtr controlProfile, Point2I value);
         private static _GuiControlProfileSetTextOffset _GuiControlProfileSetTextOffsetFunc;
         internal static void GuiControlProfileSetTextOffset(IntPtr controlProfile, Point2I value)
         {
            if (_GuiControlProfileSetTextOffsetFunc == null)
            {
               _GuiControlProfileSetTextOffsetFunc =
                  (_GuiControlProfileSetTextOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetTextOffset"), typeof(_GuiControlProfileSetTextOffset));
            }

            _GuiControlProfileSetTextOffsetFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlProfileGetAutoSizeWidth(IntPtr controlProfile);
         private static _GuiControlProfileGetAutoSizeWidth _GuiControlProfileGetAutoSizeWidthFunc;
         internal static bool GuiControlProfileGetAutoSizeWidth(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetAutoSizeWidthFunc == null)
            {
               _GuiControlProfileGetAutoSizeWidthFunc =
                  (_GuiControlProfileGetAutoSizeWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetAutoSizeWidth"), typeof(_GuiControlProfileGetAutoSizeWidth));
            }

            return _GuiControlProfileGetAutoSizeWidthFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetAutoSizeWidth(IntPtr controlProfile, bool value);
         private static _GuiControlProfileSetAutoSizeWidth _GuiControlProfileSetAutoSizeWidthFunc;
         internal static void GuiControlProfileSetAutoSizeWidth(IntPtr controlProfile, bool value)
         {
            if (_GuiControlProfileSetAutoSizeWidthFunc == null)
            {
               _GuiControlProfileSetAutoSizeWidthFunc =
                  (_GuiControlProfileSetAutoSizeWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetAutoSizeWidth"), typeof(_GuiControlProfileSetAutoSizeWidth));
            }

            _GuiControlProfileSetAutoSizeWidthFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlProfileGetAutoSizeHeight(IntPtr controlProfile);
         private static _GuiControlProfileGetAutoSizeHeight _GuiControlProfileGetAutoSizeHeightFunc;
         internal static bool GuiControlProfileGetAutoSizeHeight(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetAutoSizeHeightFunc == null)
            {
               _GuiControlProfileGetAutoSizeHeightFunc =
                  (_GuiControlProfileGetAutoSizeHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetAutoSizeHeight"), typeof(_GuiControlProfileGetAutoSizeHeight));
            }

            return _GuiControlProfileGetAutoSizeHeightFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetAutoSizeHeight(IntPtr controlProfile, bool value);
         private static _GuiControlProfileSetAutoSizeHeight _GuiControlProfileSetAutoSizeHeightFunc;
         internal static void GuiControlProfileSetAutoSizeHeight(IntPtr controlProfile, bool value)
         {
            if (_GuiControlProfileSetAutoSizeHeightFunc == null)
            {
               _GuiControlProfileSetAutoSizeHeightFunc =
                  (_GuiControlProfileSetAutoSizeHeight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetAutoSizeHeight"), typeof(_GuiControlProfileSetAutoSizeHeight));
            }

            _GuiControlProfileSetAutoSizeHeightFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlProfileGetReturnTab(IntPtr controlProfile);
         private static _GuiControlProfileGetReturnTab _GuiControlProfileGetReturnTabFunc;
         internal static bool GuiControlProfileGetReturnTab(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetReturnTabFunc == null)
            {
               _GuiControlProfileGetReturnTabFunc =
                  (_GuiControlProfileGetReturnTab)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetReturnTab"), typeof(_GuiControlProfileGetReturnTab));
            }

            return _GuiControlProfileGetReturnTabFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetReturnTab(IntPtr controlProfile, bool value);
         private static _GuiControlProfileSetReturnTab _GuiControlProfileSetReturnTabFunc;
         internal static void GuiControlProfileSetReturnTab(IntPtr controlProfile, bool value)
         {
            if (_GuiControlProfileSetReturnTabFunc == null)
            {
               _GuiControlProfileSetReturnTabFunc =
                  (_GuiControlProfileSetReturnTab)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetReturnTab"), typeof(_GuiControlProfileSetReturnTab));
            }

            _GuiControlProfileSetReturnTabFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlProfileGetNumbersOnly(IntPtr controlProfile);
         private static _GuiControlProfileGetNumbersOnly _GuiControlProfileGetNumbersOnlyFunc;
         internal static bool GuiControlProfileGetNumbersOnly(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetNumbersOnlyFunc == null)
            {
               _GuiControlProfileGetNumbersOnlyFunc =
                  (_GuiControlProfileGetNumbersOnly)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetNumbersOnly"), typeof(_GuiControlProfileGetNumbersOnly));
            }

            return _GuiControlProfileGetNumbersOnlyFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetNumbersOnly(IntPtr controlProfile, bool value);
         private static _GuiControlProfileSetNumbersOnly _GuiControlProfileSetNumbersOnlyFunc;
         internal static void GuiControlProfileSetNumbersOnly(IntPtr controlProfile, bool value)
         {
            if (_GuiControlProfileSetNumbersOnlyFunc == null)
            {
               _GuiControlProfileSetNumbersOnlyFunc =
                  (_GuiControlProfileSetNumbersOnly)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetNumbersOnly"), typeof(_GuiControlProfileSetNumbersOnly));
            }

            _GuiControlProfileSetNumbersOnlyFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileGetCursorColor(IntPtr controlProfile, out Color outColor);
         private static _GuiControlProfileGetCursorColor _GuiControlProfileGetCursorColorFunc;
         internal static void GuiControlProfileGetCursorColor(IntPtr controlProfile, out Color outColor)
         {
            if (_GuiControlProfileGetCursorColorFunc == null)
            {
               _GuiControlProfileGetCursorColorFunc =
                  (_GuiControlProfileGetCursorColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetCursorColor"), typeof(_GuiControlProfileGetCursorColor));
            }

            _GuiControlProfileGetCursorColorFunc(controlProfile, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetCursorColor(IntPtr controlProfile, Color value);
         private static _GuiControlProfileSetCursorColor _GuiControlProfileSetCursorColorFunc;
         internal static void GuiControlProfileSetCursorColor(IntPtr controlProfile, Color value)
         {
            if (_GuiControlProfileSetCursorColorFunc == null)
            {
               _GuiControlProfileSetCursorColorFunc =
                  (_GuiControlProfileSetCursorColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetCursorColor"), typeof(_GuiControlProfileSetCursorColor));
            }

            _GuiControlProfileSetCursorColorFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlProfileGetBitmap(IntPtr controlProfile);
         private static _GuiControlProfileGetBitmap _GuiControlProfileGetBitmapFunc;
         internal static IntPtr GuiControlProfileGetBitmap(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetBitmapFunc == null)
            {
               _GuiControlProfileGetBitmapFunc =
                  (_GuiControlProfileGetBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetBitmap"), typeof(_GuiControlProfileGetBitmap));
            }

            return _GuiControlProfileGetBitmapFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetBitmap(IntPtr controlProfile, string value);
         private static _GuiControlProfileSetBitmap _GuiControlProfileSetBitmapFunc;
         internal static void GuiControlProfileSetBitmap(IntPtr controlProfile, string value)
         {
            if (_GuiControlProfileSetBitmapFunc == null)
            {
               _GuiControlProfileSetBitmapFunc =
                  (_GuiControlProfileSetBitmap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetBitmap"), typeof(_GuiControlProfileSetBitmap));
            }

            _GuiControlProfileSetBitmapFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlProfileGetSoundButtonDown(IntPtr controlProfile);
         private static _GuiControlProfileGetSoundButtonDown _GuiControlProfileGetSoundButtonDownFunc;
         internal static IntPtr GuiControlProfileGetSoundButtonDown(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetSoundButtonDownFunc == null)
            {
               _GuiControlProfileGetSoundButtonDownFunc =
                  (_GuiControlProfileGetSoundButtonDown)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetSoundButtonDown"), typeof(_GuiControlProfileGetSoundButtonDown));
            }

            return _GuiControlProfileGetSoundButtonDownFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetSoundButtonDown(IntPtr controlProfile, IntPtr value);
         private static _GuiControlProfileSetSoundButtonDown _GuiControlProfileSetSoundButtonDownFunc;
         internal static void GuiControlProfileSetSoundButtonDown(IntPtr controlProfile, IntPtr value)
         {
            if (_GuiControlProfileSetSoundButtonDownFunc == null)
            {
               _GuiControlProfileSetSoundButtonDownFunc =
                  (_GuiControlProfileSetSoundButtonDown)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetSoundButtonDown"), typeof(_GuiControlProfileSetSoundButtonDown));
            }

            _GuiControlProfileSetSoundButtonDownFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlProfileGetSoundButtonOver(IntPtr controlProfile);
         private static _GuiControlProfileGetSoundButtonOver _GuiControlProfileGetSoundButtonOverFunc;
         internal static IntPtr GuiControlProfileGetSoundButtonOver(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetSoundButtonOverFunc == null)
            {
               _GuiControlProfileGetSoundButtonOverFunc =
                  (_GuiControlProfileGetSoundButtonOver)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetSoundButtonOver"), typeof(_GuiControlProfileGetSoundButtonOver));
            }

            return _GuiControlProfileGetSoundButtonOverFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetSoundButtonOver(IntPtr controlProfile, IntPtr value);
         private static _GuiControlProfileSetSoundButtonOver _GuiControlProfileSetSoundButtonOverFunc;
         internal static void GuiControlProfileSetSoundButtonOver(IntPtr controlProfile, IntPtr value)
         {
            if (_GuiControlProfileSetSoundButtonOverFunc == null)
            {
               _GuiControlProfileSetSoundButtonOverFunc =
                  (_GuiControlProfileSetSoundButtonOver)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetSoundButtonOver"), typeof(_GuiControlProfileSetSoundButtonOver));
            }

            _GuiControlProfileSetSoundButtonOverFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlProfileGetProfileForChildren(IntPtr controlProfile);
         private static _GuiControlProfileGetProfileForChildren _GuiControlProfileGetProfileForChildrenFunc;
         internal static IntPtr GuiControlProfileGetProfileForChildren(IntPtr controlProfile)
         {
            if (_GuiControlProfileGetProfileForChildrenFunc == null)
            {
               _GuiControlProfileGetProfileForChildrenFunc =
                  (_GuiControlProfileGetProfileForChildren)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileGetProfileForChildren"), typeof(_GuiControlProfileGetProfileForChildren));
            }

            return _GuiControlProfileGetProfileForChildrenFunc(controlProfile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlProfileSetProfileForChildren(IntPtr controlProfile, IntPtr value);
         private static _GuiControlProfileSetProfileForChildren _GuiControlProfileSetProfileForChildrenFunc;
         internal static void GuiControlProfileSetProfileForChildren(IntPtr controlProfile, IntPtr value)
         {
            if (_GuiControlProfileSetProfileForChildrenFunc == null)
            {
               _GuiControlProfileSetProfileForChildrenFunc =
                  (_GuiControlProfileSetProfileForChildren)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileSetProfileForChildren"), typeof(_GuiControlProfileSetProfileForChildren));
            }

            _GuiControlProfileSetProfileForChildrenFunc(controlProfile, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlProfileCreateInstance();
         private static _GuiControlProfileCreateInstance _GuiControlProfileCreateInstanceFunc;
         internal static IntPtr GuiControlProfileCreateInstance()
         {
            if (_GuiControlProfileCreateInstanceFunc == null)
            {
               _GuiControlProfileCreateInstanceFunc =
                  (_GuiControlProfileCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlProfileCreateInstance"), typeof(_GuiControlProfileCreateInstance));
            }

            return _GuiControlProfileCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public bool Tab
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetTab(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetTab(ObjectPtr->ObjPtr, value);
         }
      }
      public bool CanKeyFocus
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetCanKeyFocus(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetCanKeyFocus(ObjectPtr->ObjPtr, value);
         }
      }
      public bool MouseOverSelected
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetMouseOverSelected(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetMouseOverSelected(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Modal
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetModal(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetModal(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Opaque
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetOpaque(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetOpaque(ObjectPtr->ObjPtr, value);
         }
      }
      public Color FillColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetFillColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFillColor(ObjectPtr->ObjPtr, value);
         }
      }
      public Color FillColorHL
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetFillColorHL(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFillColorHL(ObjectPtr->ObjPtr, value);
         }
      }
      public Color FillColorNA
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetFillColorNA(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFillColorNA(ObjectPtr->ObjPtr, value);
         }
      }
      public int Border
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetBorder(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetBorder(ObjectPtr->ObjPtr, value);
         }
      }
      public int BorderThickness
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetBorderThickness(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetBorderThickness(ObjectPtr->ObjPtr, value);
         }
      }
      public Color BorderColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetBorderColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetBorderColor(ObjectPtr->ObjPtr, value);
         }
      }
      public Color BorderColorHL
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetBorderColorHL(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetBorderColorHL(ObjectPtr->ObjPtr, value);
         }
      }
      public Color BorderColorNA
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetBorderColorNA(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetBorderColorNA(ObjectPtr->ObjPtr, value);
         }
      }
      public Color BevelColorHL
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetBevelColorHL(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetBevelColorHL(ObjectPtr->ObjPtr, value);
         }
      }
      public Color BevelColorLL
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetBevelColorLL(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetBevelColorLL(ObjectPtr->ObjPtr, value);
         }
      }
      public string FontType
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiControlProfileGetFontType(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFontType(ObjectPtr->ObjPtr, value);
         }
      }
      public int FontSize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetFontSize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFontSize(ObjectPtr->ObjPtr, value);
         }
      }
      public int FontCharset
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetFontCharset(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFontCharset(ObjectPtr->ObjPtr, value);
         }
      }

      public FieldVector<Color> FontColors
      {
         get
         {
            return new FieldVector<Color>(this, 10, InternalUnsafeMethods.GuiControlProfileGetFontColors,
               InternalUnsafeMethods.GuiControlProfileSetFontColors);
         }
      }
      public Color FontColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetFontColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFontColor(ObjectPtr->ObjPtr, value);
         }
      }
      public Color FontColorHL
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetFontColorHL(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFontColorHL(ObjectPtr->ObjPtr, value);
         }
      }
      public Color FontColorNA
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetFontColorNA(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFontColorNA(ObjectPtr->ObjPtr, value);
         }
      }
      public Color FontColorSEL
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetFontColorSEL(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFontColorSEL(ObjectPtr->ObjPtr, value);
         }
      }
      public Color FontColorLink
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetFontColorLink(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFontColorLink(ObjectPtr->ObjPtr, value);
         }
      }
      public Color FontColorLinkHL
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetFontColorLinkHL(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetFontColorLinkHL(ObjectPtr->ObjPtr, value);
         }
      }
      public int Justify
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetJustify(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetJustify(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I TextOffset
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetTextOffset(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetTextOffset(ObjectPtr->ObjPtr, value);
         }
      }
      public bool AutoSizeWidth
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetAutoSizeWidth(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetAutoSizeWidth(ObjectPtr->ObjPtr, value);
         }
      }
      public bool AutoSizeHeight
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetAutoSizeHeight(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetAutoSizeHeight(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ReturnTab
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetReturnTab(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetReturnTab(ObjectPtr->ObjPtr, value);
         }
      }
      public bool NumbersOnly
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlProfileGetNumbersOnly(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetNumbersOnly(ObjectPtr->ObjPtr, value);
         }
      }
      public Color CursorColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiControlProfileGetCursorColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetCursorColor(ObjectPtr->ObjPtr, value);
         }
      }
      public string Bitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiControlProfileGetBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      public AudioAsset SoundButtonDown
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new AudioAsset(InternalUnsafeMethods.GuiControlProfileGetSoundButtonDown(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetSoundButtonDown(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      public AudioAsset SoundButtonOver
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new AudioAsset(InternalUnsafeMethods.GuiControlProfileGetSoundButtonOver(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetSoundButtonOver(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      public GuiControlProfile ProfileForChildren
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new GuiControlProfile(InternalUnsafeMethods.GuiControlProfileGetProfileForChildren(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlProfileSetProfileForChildren(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}