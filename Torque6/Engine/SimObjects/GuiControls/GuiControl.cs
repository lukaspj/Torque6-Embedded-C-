using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiControl : SimGroup
   {
      
      public GuiControl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiControlCreateInstance());
      }

      public GuiControl(uint pId) : base(pId)
      {
      }

      public GuiControl(string pName) : base(pName)
      {
      }

      public GuiControl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiControl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiControl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlGetIsContainer(IntPtr ctrl);
         private static _GuiControlGetIsContainer _GuiControlGetIsContainerFunc;
         internal static bool GuiControlGetIsContainer(IntPtr ctrl)
         {
            if (_GuiControlGetIsContainerFunc == null)
            {
               _GuiControlGetIsContainerFunc =
                  (_GuiControlGetIsContainer)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetIsContainer"), typeof(_GuiControlGetIsContainer));
            }

            return _GuiControlGetIsContainerFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetIsContainer(IntPtr ctrl, bool container);
         private static _GuiControlSetIsContainer _GuiControlSetIsContainerFunc;
         internal static void GuiControlSetIsContainer(IntPtr ctrl, bool container)
         {
            if (_GuiControlSetIsContainerFunc == null)
            {
               _GuiControlSetIsContainerFunc =
                  (_GuiControlSetIsContainer)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetIsContainer"), typeof(_GuiControlSetIsContainer));
            }

            _GuiControlSetIsContainerFunc(ctrl, container);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetProfile(IntPtr ctrl);
         private static _GuiControlGetProfile _GuiControlGetProfileFunc;
         internal static IntPtr GuiControlGetProfile(IntPtr ctrl)
         {
            if (_GuiControlGetProfileFunc == null)
            {
               _GuiControlGetProfileFunc =
                  (_GuiControlGetProfile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetProfile"), typeof(_GuiControlGetProfile));
            }

            return _GuiControlGetProfileFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetProfile(IntPtr ctrl, IntPtr profile);
         private static _GuiControlSetProfile _GuiControlSetProfileFunc;
         internal static void GuiControlSetProfile(IntPtr ctrl, IntPtr profile)
         {
            if (_GuiControlSetProfileFunc == null)
            {
               _GuiControlSetProfileFunc =
                  (_GuiControlSetProfile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetProfile"), typeof(_GuiControlSetProfile));
            }

            _GuiControlSetProfileFunc(ctrl, profile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlGetHorizSizing(IntPtr ctrl);
         private static _GuiControlGetHorizSizing _GuiControlGetHorizSizingFunc;
         internal static int GuiControlGetHorizSizing(IntPtr ctrl)
         {
            if (_GuiControlGetHorizSizingFunc == null)
            {
               _GuiControlGetHorizSizingFunc =
                  (_GuiControlGetHorizSizing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetHorizSizing"), typeof(_GuiControlGetHorizSizing));
            }

            return _GuiControlGetHorizSizingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetHorizSizing(IntPtr ctrl, int sizing);
         private static _GuiControlSetHorizSizing _GuiControlSetHorizSizingFunc;
         internal static void GuiControlSetHorizSizing(IntPtr ctrl, int sizing)
         {
            if (_GuiControlSetHorizSizingFunc == null)
            {
               _GuiControlSetHorizSizingFunc =
                  (_GuiControlSetHorizSizing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetHorizSizing"), typeof(_GuiControlSetHorizSizing));
            }

            _GuiControlSetHorizSizingFunc(ctrl, sizing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlGetVertSizing(IntPtr ctrl);
         private static _GuiControlGetVertSizing _GuiControlGetVertSizingFunc;
         internal static int GuiControlGetVertSizing(IntPtr ctrl)
         {
            if (_GuiControlGetVertSizingFunc == null)
            {
               _GuiControlGetVertSizingFunc =
                  (_GuiControlGetVertSizing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetVertSizing"), typeof(_GuiControlGetVertSizing));
            }

            return _GuiControlGetVertSizingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetVertSizing(IntPtr ctrl, int sizing);
         private static _GuiControlSetVertSizing _GuiControlSetVertSizingFunc;
         internal static void GuiControlSetVertSizing(IntPtr ctrl, int sizing)
         {
            if (_GuiControlSetVertSizingFunc == null)
            {
               _GuiControlSetVertSizingFunc =
                  (_GuiControlSetVertSizing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetVertSizing"), typeof(_GuiControlSetVertSizing));
            }

            _GuiControlSetVertSizingFunc(ctrl, sizing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlGetPosition(IntPtr ctrl, out Point2I outPos);
         private static _GuiControlGetPosition _GuiControlGetPositionFunc;
         internal static void GuiControlGetPosition(IntPtr ctrl, out Point2I outPos)
         {
            if (_GuiControlGetPositionFunc == null)
            {
               _GuiControlGetPositionFunc =
                  (_GuiControlGetPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetPosition"), typeof(_GuiControlGetPosition));
            }

            _GuiControlGetPositionFunc(ctrl, out outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetPosition(IntPtr ctrl, Point2I pos);
         private static _GuiControlSetPosition _GuiControlSetPositionFunc;
         internal static void GuiControlSetPosition(IntPtr ctrl, Point2I pos)
         {
            if (_GuiControlSetPositionFunc == null)
            {
               _GuiControlSetPositionFunc =
                  (_GuiControlSetPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetPosition"), typeof(_GuiControlSetPosition));
            }

            _GuiControlSetPositionFunc(ctrl, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlGetExtent(IntPtr ctrl, out Point2I outExt);
         private static _GuiControlGetExtent _GuiControlGetExtentFunc;
         internal static void GuiControlGetExtent(IntPtr ctrl, out Point2I outExt)
         {
            if (_GuiControlGetExtentFunc == null)
            {
               _GuiControlGetExtentFunc =
                  (_GuiControlGetExtent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetExtent"), typeof(_GuiControlGetExtent));
            }

            _GuiControlGetExtentFunc(ctrl, out outExt);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetExtent(IntPtr ctrl, Point2I ext);
         private static _GuiControlSetExtent _GuiControlSetExtentFunc;
         internal static void GuiControlSetExtent(IntPtr ctrl, Point2I ext)
         {
            if (_GuiControlSetExtentFunc == null)
            {
               _GuiControlSetExtentFunc =
                  (_GuiControlSetExtent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetExtent"), typeof(_GuiControlSetExtent));
            }

            _GuiControlSetExtentFunc(ctrl, ext);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlGetMinExtent(IntPtr ctrl, out Point2I outExt);
         private static _GuiControlGetMinExtent _GuiControlGetMinExtentFunc;
         internal static void GuiControlGetMinExtent(IntPtr ctrl, out Point2I outExt)
         {
            if (_GuiControlGetMinExtentFunc == null)
            {
               _GuiControlGetMinExtentFunc =
                  (_GuiControlGetMinExtent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetMinExtent"), typeof(_GuiControlGetMinExtent));
            }

            _GuiControlGetMinExtentFunc(ctrl, out outExt);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetMinExtent(IntPtr ctrl, Point2I ext);
         private static _GuiControlSetMinExtent _GuiControlSetMinExtentFunc;
         internal static void GuiControlSetMinExtent(IntPtr ctrl, Point2I ext)
         {
            if (_GuiControlSetMinExtentFunc == null)
            {
               _GuiControlSetMinExtentFunc =
                  (_GuiControlSetMinExtent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetMinExtent"), typeof(_GuiControlSetMinExtent));
            }

            _GuiControlSetMinExtentFunc(ctrl, ext);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlGetCanSave(IntPtr ctrl);
         private static _GuiControlGetCanSave _GuiControlGetCanSaveFunc;
         internal static bool GuiControlGetCanSave(IntPtr ctrl)
         {
            if (_GuiControlGetCanSaveFunc == null)
            {
               _GuiControlGetCanSaveFunc =
                  (_GuiControlGetCanSave)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetCanSave"), typeof(_GuiControlGetCanSave));
            }

            return _GuiControlGetCanSaveFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetCanSave(IntPtr ctrl, bool canSave);
         private static _GuiControlSetCanSave _GuiControlSetCanSaveFunc;
         internal static void GuiControlSetCanSave(IntPtr ctrl, bool canSave)
         {
            if (_GuiControlSetCanSaveFunc == null)
            {
               _GuiControlSetCanSaveFunc =
                  (_GuiControlSetCanSave)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetCanSave"), typeof(_GuiControlSetCanSave));
            }

            _GuiControlSetCanSaveFunc(ctrl, canSave);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlGetVisible(IntPtr ctrl);
         private static _GuiControlGetVisible _GuiControlGetVisibleFunc;
         internal static bool GuiControlGetVisible(IntPtr ctrl)
         {
            if (_GuiControlGetVisibleFunc == null)
            {
               _GuiControlGetVisibleFunc =
                  (_GuiControlGetVisible)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetVisible"), typeof(_GuiControlGetVisible));
            }

            return _GuiControlGetVisibleFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetVisible(IntPtr ctrl, bool isVisible);
         private static _GuiControlSetVisible _GuiControlSetVisibleFunc;
         internal static void GuiControlSetVisible(IntPtr ctrl, bool isVisible)
         {
            if (_GuiControlSetVisibleFunc == null)
            {
               _GuiControlSetVisibleFunc =
                  (_GuiControlSetVisible)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetVisible"), typeof(_GuiControlSetVisible));
            }

            _GuiControlSetVisibleFunc(ctrl, isVisible);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetVariable(IntPtr ctrl);
         private static _GuiControlGetVariable _GuiControlGetVariableFunc;
         internal static IntPtr GuiControlGetVariable(IntPtr ctrl)
         {
            if (_GuiControlGetVariableFunc == null)
            {
               _GuiControlGetVariableFunc =
                  (_GuiControlGetVariable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetVariable"), typeof(_GuiControlGetVariable));
            }

            return _GuiControlGetVariableFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetVariable(IntPtr ctrl, string variable);
         private static _GuiControlSetVariable _GuiControlSetVariableFunc;
         internal static void GuiControlSetVariable(IntPtr ctrl, string variable)
         {
            if (_GuiControlSetVariableFunc == null)
            {
               _GuiControlSetVariableFunc =
                  (_GuiControlSetVariable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetVariable"), typeof(_GuiControlSetVariable));
            }

            _GuiControlSetVariableFunc(ctrl, variable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetCommand(IntPtr ctrl);
         private static _GuiControlGetCommand _GuiControlGetCommandFunc;
         internal static IntPtr GuiControlGetCommand(IntPtr ctrl)
         {
            if (_GuiControlGetCommandFunc == null)
            {
               _GuiControlGetCommandFunc =
                  (_GuiControlGetCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetCommand"), typeof(_GuiControlGetCommand));
            }

            return _GuiControlGetCommandFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetCommand(IntPtr ctrl, string command);
         private static _GuiControlSetCommand _GuiControlSetCommandFunc;
         internal static void GuiControlSetCommand(IntPtr ctrl, string command)
         {
            if (_GuiControlSetCommandFunc == null)
            {
               _GuiControlSetCommandFunc =
                  (_GuiControlSetCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetCommand"), typeof(_GuiControlSetCommand));
            }

            _GuiControlSetCommandFunc(ctrl, command);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetAltCommand(IntPtr ctrl);
         private static _GuiControlGetAltCommand _GuiControlGetAltCommandFunc;
         internal static IntPtr GuiControlGetAltCommand(IntPtr ctrl)
         {
            if (_GuiControlGetAltCommandFunc == null)
            {
               _GuiControlGetAltCommandFunc =
                  (_GuiControlGetAltCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetAltCommand"), typeof(_GuiControlGetAltCommand));
            }

            return _GuiControlGetAltCommandFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetAltCommand(IntPtr ctrl, string command);
         private static _GuiControlSetAltCommand _GuiControlSetAltCommandFunc;
         internal static void GuiControlSetAltCommand(IntPtr ctrl, string command)
         {
            if (_GuiControlSetAltCommandFunc == null)
            {
               _GuiControlSetAltCommandFunc =
                  (_GuiControlSetAltCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetAltCommand"), typeof(_GuiControlSetAltCommand));
            }

            _GuiControlSetAltCommandFunc(ctrl, command);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetAccelerator(IntPtr ctrl);
         private static _GuiControlGetAccelerator _GuiControlGetAcceleratorFunc;
         internal static IntPtr GuiControlGetAccelerator(IntPtr ctrl)
         {
            if (_GuiControlGetAcceleratorFunc == null)
            {
               _GuiControlGetAcceleratorFunc =
                  (_GuiControlGetAccelerator)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetAccelerator"), typeof(_GuiControlGetAccelerator));
            }

            return _GuiControlGetAcceleratorFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetAccelerator(IntPtr ctrl, string acceleratorKey);
         private static _GuiControlSetAccelerator _GuiControlSetAcceleratorFunc;
         internal static void GuiControlSetAccelerator(IntPtr ctrl, string acceleratorKey)
         {
            if (_GuiControlSetAcceleratorFunc == null)
            {
               _GuiControlSetAcceleratorFunc =
                  (_GuiControlSetAccelerator)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetAccelerator"), typeof(_GuiControlSetAccelerator));
            }

            _GuiControlSetAcceleratorFunc(ctrl, acceleratorKey);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlGetActive(IntPtr ctrl);
         private static _GuiControlGetActive _GuiControlGetActiveFunc;
         internal static bool GuiControlGetActive(IntPtr ctrl)
         {
            if (_GuiControlGetActiveFunc == null)
            {
               _GuiControlGetActiveFunc =
                  (_GuiControlGetActive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetActive"), typeof(_GuiControlGetActive));
            }

            return _GuiControlGetActiveFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetActive(IntPtr ctrl, bool isActive);
         private static _GuiControlSetActive _GuiControlSetActiveFunc;
         internal static void GuiControlSetActive(IntPtr ctrl, bool isActive)
         {
            if (_GuiControlSetActiveFunc == null)
            {
               _GuiControlSetActiveFunc =
                  (_GuiControlSetActive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetActive"), typeof(_GuiControlSetActive));
            }

            _GuiControlSetActiveFunc(ctrl, isActive);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetTooltipProfile(IntPtr ctrl);
         private static _GuiControlGetTooltipProfile _GuiControlGetTooltipProfileFunc;
         internal static IntPtr GuiControlGetTooltipProfile(IntPtr ctrl)
         {
            if (_GuiControlGetTooltipProfileFunc == null)
            {
               _GuiControlGetTooltipProfileFunc =
                  (_GuiControlGetTooltipProfile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetTooltipProfile"), typeof(_GuiControlGetTooltipProfile));
            }

            return _GuiControlGetTooltipProfileFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetTooltipProfile(IntPtr ctrl, IntPtr profile);
         private static _GuiControlSetTooltipProfile _GuiControlSetTooltipProfileFunc;
         internal static void GuiControlSetTooltipProfile(IntPtr ctrl, IntPtr profile)
         {
            if (_GuiControlSetTooltipProfileFunc == null)
            {
               _GuiControlSetTooltipProfileFunc =
                  (_GuiControlSetTooltipProfile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetTooltipProfile"), typeof(_GuiControlSetTooltipProfile));
            }

            _GuiControlSetTooltipProfileFunc(ctrl, profile);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetTooltip(IntPtr ctrl);
         private static _GuiControlGetTooltip _GuiControlGetTooltipFunc;
         internal static IntPtr GuiControlGetTooltip(IntPtr ctrl)
         {
            if (_GuiControlGetTooltipFunc == null)
            {
               _GuiControlGetTooltipFunc =
                  (_GuiControlGetTooltip)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetTooltip"), typeof(_GuiControlGetTooltip));
            }

            return _GuiControlGetTooltipFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetTooltip(IntPtr ctrl, string tooltip);
         private static _GuiControlSetTooltip _GuiControlSetTooltipFunc;
         internal static void GuiControlSetTooltip(IntPtr ctrl, string tooltip)
         {
            if (_GuiControlSetTooltipFunc == null)
            {
               _GuiControlSetTooltipFunc =
                  (_GuiControlSetTooltip)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetTooltip"), typeof(_GuiControlSetTooltip));
            }

            _GuiControlSetTooltipFunc(ctrl, tooltip);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlGetTooltipWidth(IntPtr ctrl);
         private static _GuiControlGetTooltipWidth _GuiControlGetTooltipWidthFunc;
         internal static int GuiControlGetTooltipWidth(IntPtr ctrl)
         {
            if (_GuiControlGetTooltipWidthFunc == null)
            {
               _GuiControlGetTooltipWidthFunc =
                  (_GuiControlGetTooltipWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetTooltipWidth"), typeof(_GuiControlGetTooltipWidth));
            }

            return _GuiControlGetTooltipWidthFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetTooltipWidth(IntPtr ctrl, int width);
         private static _GuiControlSetTooltipWidth _GuiControlSetTooltipWidthFunc;
         internal static void GuiControlSetTooltipWidth(IntPtr ctrl, int width)
         {
            if (_GuiControlSetTooltipWidthFunc == null)
            {
               _GuiControlSetTooltipWidthFunc =
                  (_GuiControlSetTooltipWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetTooltipWidth"), typeof(_GuiControlSetTooltipWidth));
            }

            _GuiControlSetTooltipWidthFunc(ctrl, width);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiControlGetHoverTime(IntPtr ctrl);
         private static _GuiControlGetHoverTime _GuiControlGetHoverTimeFunc;
         internal static int GuiControlGetHoverTime(IntPtr ctrl)
         {
            if (_GuiControlGetHoverTimeFunc == null)
            {
               _GuiControlGetHoverTimeFunc =
                  (_GuiControlGetHoverTime)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetHoverTime"), typeof(_GuiControlGetHoverTime));
            }

            return _GuiControlGetHoverTimeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetHoverTime(IntPtr ctrl, int time);
         private static _GuiControlSetHoverTime _GuiControlSetHoverTimeFunc;
         internal static void GuiControlSetHoverTime(IntPtr ctrl, int time)
         {
            if (_GuiControlSetHoverTimeFunc == null)
            {
               _GuiControlSetHoverTimeFunc =
                  (_GuiControlSetHoverTime)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetHoverTime"), typeof(_GuiControlSetHoverTime));
            }

            _GuiControlSetHoverTimeFunc(ctrl, time);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetLangTableMod(IntPtr ctrl);
         private static _GuiControlGetLangTableMod _GuiControlGetLangTableModFunc;
         internal static IntPtr GuiControlGetLangTableMod(IntPtr ctrl)
         {
            if (_GuiControlGetLangTableModFunc == null)
            {
               _GuiControlGetLangTableModFunc =
                  (_GuiControlGetLangTableMod)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetLangTableMod"), typeof(_GuiControlGetLangTableMod));
            }

            return _GuiControlGetLangTableModFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetLangTableMod(IntPtr ctrl, string langTableName);
         private static _GuiControlSetLangTableMod _GuiControlSetLangTableModFunc;
         internal static void GuiControlSetLangTableMod(IntPtr ctrl, string langTableName)
         {
            if (_GuiControlSetLangTableModFunc == null)
            {
               _GuiControlSetLangTableModFunc =
                  (_GuiControlSetLangTableMod)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetLangTableMod"), typeof(_GuiControlSetLangTableMod));
            }

            _GuiControlSetLangTableModFunc(ctrl, langTableName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlCreateInstance();
         private static _GuiControlCreateInstance _GuiControlCreateInstanceFunc;
         internal static IntPtr GuiControlCreateInstance()
         {
            if (_GuiControlCreateInstanceFunc == null)
            {
               _GuiControlCreateInstanceFunc =
                  (_GuiControlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlCreateInstance"), typeof(_GuiControlCreateInstance));
            }

            return _GuiControlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlPointInControl(IntPtr ctrl, Point2I point);
         private static _GuiControlPointInControl _GuiControlPointInControlFunc;
         internal static bool GuiControlPointInControl(IntPtr ctrl, Point2I point)
         {
            if (_GuiControlPointInControlFunc == null)
            {
               _GuiControlPointInControlFunc =
                  (_GuiControlPointInControl)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlPointInControl"), typeof(_GuiControlPointInControl));
            }

            return _GuiControlPointInControlFunc(ctrl, point);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlAddGuiControl(IntPtr ctrl, IntPtr guiCtrl);
         private static _GuiControlAddGuiControl _GuiControlAddGuiControlFunc;
         internal static void GuiControlAddGuiControl(IntPtr ctrl, IntPtr guiCtrl)
         {
            if (_GuiControlAddGuiControlFunc == null)
            {
               _GuiControlAddGuiControlFunc =
                  (_GuiControlAddGuiControl)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlAddGuiControl"), typeof(_GuiControlAddGuiControl));
            }

            _GuiControlAddGuiControlFunc(ctrl, guiCtrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlReorderChild(IntPtr ctrl, IntPtr child1, IntPtr child2);
         private static _GuiControlReorderChild _GuiControlReorderChildFunc;
         internal static void GuiControlReorderChild(IntPtr ctrl, IntPtr child1, IntPtr child2)
         {
            if (_GuiControlReorderChildFunc == null)
            {
               _GuiControlReorderChildFunc =
                  (_GuiControlReorderChild)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlReorderChild"), typeof(_GuiControlReorderChild));
            }

            _GuiControlReorderChildFunc(ctrl, child1, child2);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetParent(IntPtr ctrl);
         private static _GuiControlGetParent _GuiControlGetParentFunc;
         internal static IntPtr GuiControlGetParent(IntPtr ctrl)
         {
            if (_GuiControlGetParentFunc == null)
            {
               _GuiControlGetParentFunc =
                  (_GuiControlGetParent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetParent"), typeof(_GuiControlGetParent));
            }

            return _GuiControlGetParentFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetValue(IntPtr ctrl, string value);
         private static _GuiControlSetValue _GuiControlSetValueFunc;
         internal static void GuiControlSetValue(IntPtr ctrl, string value)
         {
            if (_GuiControlSetValueFunc == null)
            {
               _GuiControlSetValueFunc =
                  (_GuiControlSetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetValue"), typeof(_GuiControlSetValue));
            }

            _GuiControlSetValueFunc(ctrl, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlGetValue(IntPtr ctrl);
         private static _GuiControlGetValue _GuiControlGetValueFunc;
         internal static IntPtr GuiControlGetValue(IntPtr ctrl)
         {
            if (_GuiControlGetValueFunc == null)
            {
               _GuiControlGetValueFunc =
                  (_GuiControlGetValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetValue"), typeof(_GuiControlGetValue));
            }

            return _GuiControlGetValueFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlIsActive(IntPtr ctrl);
         private static _GuiControlIsActive _GuiControlIsActiveFunc;
         internal static bool GuiControlIsActive(IntPtr ctrl)
         {
            if (_GuiControlIsActiveFunc == null)
            {
               _GuiControlIsActiveFunc =
                  (_GuiControlIsActive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlIsActive"), typeof(_GuiControlIsActive));
            }

            return _GuiControlIsActiveFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlIsVisible(IntPtr ctrl);
         private static _GuiControlIsVisible _GuiControlIsVisibleFunc;
         internal static bool GuiControlIsVisible(IntPtr ctrl)
         {
            if (_GuiControlIsVisibleFunc == null)
            {
               _GuiControlIsVisibleFunc =
                  (_GuiControlIsVisible)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlIsVisible"), typeof(_GuiControlIsVisible));
            }

            return _GuiControlIsVisibleFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlMakeFirstResponder(IntPtr ctrl, bool isFirst);
         private static _GuiControlMakeFirstResponder _GuiControlMakeFirstResponderFunc;
         internal static void GuiControlMakeFirstResponder(IntPtr ctrl, bool isFirst)
         {
            if (_GuiControlMakeFirstResponderFunc == null)
            {
               _GuiControlMakeFirstResponderFunc =
                  (_GuiControlMakeFirstResponder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlMakeFirstResponder"), typeof(_GuiControlMakeFirstResponder));
            }

            _GuiControlMakeFirstResponderFunc(ctrl, isFirst);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiControlIsAwake(IntPtr ctrl);
         private static _GuiControlIsAwake _GuiControlIsAwakeFunc;
         internal static bool GuiControlIsAwake(IntPtr ctrl)
         {
            if (_GuiControlIsAwakeFunc == null)
            {
               _GuiControlIsAwakeFunc =
                  (_GuiControlIsAwake)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlIsAwake"), typeof(_GuiControlIsAwake));
            }

            return _GuiControlIsAwakeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlResize(IntPtr ctrl, Point2I newPos, Point2I newExt);
         private static _GuiControlResize _GuiControlResizeFunc;
         internal static void GuiControlResize(IntPtr ctrl, Point2I newPos, Point2I newExt)
         {
            if (_GuiControlResizeFunc == null)
            {
               _GuiControlResizeFunc =
                  (_GuiControlResize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlResize"), typeof(_GuiControlResize));
            }

            _GuiControlResizeFunc(ctrl, newPos, newExt);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlGetCenter(IntPtr ctrl, Point2I outPos);
         private static _GuiControlGetCenter _GuiControlGetCenterFunc;
         internal static void GuiControlGetCenter(IntPtr ctrl, Point2I outPos)
         {
            if (_GuiControlGetCenterFunc == null)
            {
               _GuiControlGetCenterFunc =
                  (_GuiControlGetCenter)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetCenter"), typeof(_GuiControlGetCenter));
            }

            _GuiControlGetCenterFunc(ctrl, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetCenter(IntPtr ctrl, Point2I newCenter);
         private static _GuiControlSetCenter _GuiControlSetCenterFunc;
         internal static void GuiControlSetCenter(IntPtr ctrl, Point2I newCenter)
         {
            if (_GuiControlSetCenterFunc == null)
            {
               _GuiControlSetCenterFunc =
                  (_GuiControlSetCenter)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetCenter"), typeof(_GuiControlSetCenter));
            }

            _GuiControlSetCenterFunc(ctrl, newCenter);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlGetGlobalCenter(IntPtr ctrl, Point2I outPos);
         private static _GuiControlGetGlobalCenter _GuiControlGetGlobalCenterFunc;
         internal static void GuiControlGetGlobalCenter(IntPtr ctrl, Point2I outPos)
         {
            if (_GuiControlGetGlobalCenterFunc == null)
            {
               _GuiControlGetGlobalCenterFunc =
                  (_GuiControlGetGlobalCenter)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetGlobalCenter"), typeof(_GuiControlGetGlobalCenter));
            }

            _GuiControlGetGlobalCenterFunc(ctrl, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlGetGlobalPosition(IntPtr ctrl, Point2I outPos);
         private static _GuiControlGetGlobalPosition _GuiControlGetGlobalPositionFunc;
         internal static void GuiControlGetGlobalPosition(IntPtr ctrl, Point2I outPos)
         {
            if (_GuiControlGetGlobalPositionFunc == null)
            {
               _GuiControlGetGlobalPositionFunc =
                  (_GuiControlGetGlobalPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlGetGlobalPosition"), typeof(_GuiControlGetGlobalPosition));
            }

            _GuiControlGetGlobalPositionFunc(ctrl, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetPositionGlobal(IntPtr ctrl, Point2I pos);
         private static _GuiControlSetPositionGlobal _GuiControlSetPositionGlobalFunc;
         internal static void GuiControlSetPositionGlobal(IntPtr ctrl, Point2I pos)
         {
            if (_GuiControlSetPositionGlobalFunc == null)
            {
               _GuiControlSetPositionGlobalFunc =
                  (_GuiControlSetPositionGlobal)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetPositionGlobal"), typeof(_GuiControlSetPositionGlobal));
            }

            _GuiControlSetPositionGlobalFunc(ctrl, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlFindHitControl(IntPtr ctrl, Point2I pos);
         private static _GuiControlFindHitControl _GuiControlFindHitControlFunc;
         internal static IntPtr GuiControlFindHitControl(IntPtr ctrl, Point2I pos)
         {
            if (_GuiControlFindHitControlFunc == null)
            {
               _GuiControlFindHitControlFunc =
                  (_GuiControlFindHitControl)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlFindHitControl"), typeof(_GuiControlFindHitControl));
            }

            return _GuiControlFindHitControlFunc(ctrl, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiControlSetFirstResponder(IntPtr ctrl);
         private static _GuiControlSetFirstResponder _GuiControlSetFirstResponderFunc;
         internal static void GuiControlSetFirstResponder(IntPtr ctrl)
         {
            if (_GuiControlSetFirstResponderFunc == null)
            {
               _GuiControlSetFirstResponderFunc =
                  (_GuiControlSetFirstResponder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiControlSetFirstResponder"), typeof(_GuiControlSetFirstResponder));
            }

            _GuiControlSetFirstResponderFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public bool IsContainer
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlGetIsContainer(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetIsContainer(ObjectPtr->ObjPtr, value);
         }
      }
      public GuiControlProfile Profile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new GuiControlProfile(InternalUnsafeMethods.GuiControlGetProfile(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetProfile(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      public int HorizSizing
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlGetHorizSizing(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetHorizSizing(ObjectPtr->ObjPtr, value);
         }
      }
      public int VertSizing
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlGetVertSizing(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetVertSizing(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I Position
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiControlGetPosition(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetPosition(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I Extent
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiControlGetExtent(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetExtent(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2I MinExtent
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiControlGetMinExtent(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetMinExtent(ObjectPtr->ObjPtr, value);
         }
      }
      public bool CanSave
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlGetCanSave(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetCanSave(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Visible
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlGetVisible(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetVisible(ObjectPtr->ObjPtr, value);
         }
      }
      public string Variable
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiControlGetVariable(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetVariable(ObjectPtr->ObjPtr, value);
         }
      }
      public string Command
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiControlGetCommand(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetCommand(ObjectPtr->ObjPtr, value);
         }
      }
      public string AltCommand
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiControlGetAltCommand(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetAltCommand(ObjectPtr->ObjPtr, value);
         }
      }
      public string Accelerator
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiControlGetAccelerator(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetAccelerator(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Active
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlGetActive(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetActive(ObjectPtr->ObjPtr, value);
         }
      }
      public GuiControlProfile Tooltipprofile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new GuiControlProfile(InternalUnsafeMethods.GuiControlGetTooltipProfile(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetTooltipProfile(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      public string Tooltip
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiControlGetTooltip(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetTooltip(ObjectPtr->ObjPtr, value);
         }
      }
      public int TooltipWidth
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlGetTooltipWidth(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetTooltipWidth(ObjectPtr->ObjPtr, value);
         }
      }
      public int Hovertime
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiControlGetHoverTime(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetHoverTime(ObjectPtr->ObjPtr, value);
         }
      }
      public string LangTableMod
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiControlGetLangTableMod(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiControlSetLangTableMod(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool PointInControl(Point2I point)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiControlPointInControl(ObjectPtr->ObjPtr, point);
      }

      public void AddGuiControl(GuiControl guiCtrl)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlAddGuiControl(ObjectPtr->ObjPtr, guiCtrl.ObjectPtr->ObjPtr);
      }

      public void ReorderChild(GuiControl child1, GuiControl child2)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlReorderChild(ObjectPtr->ObjPtr, child1.ObjectPtr->ObjPtr, child2.ObjectPtr->ObjPtr);
      }

      public GuiControl GetParent()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new GuiControl(InternalUnsafeMethods.GuiControlGetParent(ObjectPtr->ObjPtr));
      }

      public void SetValue(string value)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlSetValue(ObjectPtr->ObjPtr, value);
      }

      public string GetValue()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiControlGetValue(ObjectPtr->ObjPtr));
      }

      public bool IsActive()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiControlIsActive(ObjectPtr->ObjPtr);
      }

      public bool IsVisible()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiControlIsVisible(ObjectPtr->ObjPtr);
      }

      public void MakeFirstResponder(bool isFirst)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlMakeFirstResponder(ObjectPtr->ObjPtr, isFirst);
      }

      public bool IsAwake()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiControlIsAwake(ObjectPtr->ObjPtr);
      }

      public void Resize(Point2I newPos, Point2I newExt)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlResize(ObjectPtr->ObjPtr, newPos, newExt);
      }

      public void GetCenter(Point2I outPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlGetCenter(ObjectPtr->ObjPtr, outPos);
      }

      public void SetCenter(Point2I newCenter)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlSetCenter(ObjectPtr->ObjPtr, newCenter);
      }

      public void GetGlobalCenter(Point2I outPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlGetGlobalCenter(ObjectPtr->ObjPtr, outPos);
      }

      public void GetGlobalPosition(Point2I outPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlGetGlobalPosition(ObjectPtr->ObjPtr, outPos);
      }

      public void SetPositionGlobal(Point2I pos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlSetPositionGlobal(ObjectPtr->ObjPtr, pos);
      }

      public GuiControl FindHitControl(Point2I pos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new GuiControl(InternalUnsafeMethods.GuiControlFindHitControl(ObjectPtr->ObjPtr, pos));
      }

      public void SetFirstResponder()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiControlSetFirstResponder(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}