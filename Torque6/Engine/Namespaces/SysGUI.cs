using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class SysGUI
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_SetEnabled(bool enable);
         private static _SysGUI_SetEnabled _SysGUI_SetEnabledFunc;
         internal static void SysGUI_SetEnabled(bool enable)
         {
            if (_SysGUI_SetEnabledFunc == null)
            {
               _SysGUI_SetEnabledFunc =
                  (_SysGUI_SetEnabled)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_SetEnabled"), typeof(_SysGUI_SetEnabled));
            }

            _SysGUI_SetEnabledFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_BeginScrollArea(string title, uint x, uint y, uint width, uint height);
         private static _SysGUI_BeginScrollArea _SysGUI_BeginScrollAreaFunc;
         internal static int SysGUI_BeginScrollArea(string title, uint x, uint y, uint width, uint height)
         {
            if (_SysGUI_BeginScrollAreaFunc == null)
            {
               _SysGUI_BeginScrollAreaFunc =
                  (_SysGUI_BeginScrollArea)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_BeginScrollArea"), typeof(_SysGUI_BeginScrollArea));
            }

            return _SysGUI_BeginScrollAreaFunc(title, x, y, width, height);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_EndScrollArea();
         private static _SysGUI_EndScrollArea _SysGUI_EndScrollAreaFunc;
         internal static int SysGUI_EndScrollArea()
         {
            if (_SysGUI_EndScrollAreaFunc == null)
            {
               _SysGUI_EndScrollAreaFunc =
                  (_SysGUI_EndScrollArea)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_EndScrollArea"), typeof(_SysGUI_EndScrollArea));
            }

            return _SysGUI_EndScrollAreaFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_BeginCollapse(string label, string text, bool open);
         private static _SysGUI_BeginCollapse _SysGUI_BeginCollapseFunc;
         internal static int SysGUI_BeginCollapse(string label, string text, bool open)
         {
            if (_SysGUI_BeginCollapseFunc == null)
            {
               _SysGUI_BeginCollapseFunc =
                  (_SysGUI_BeginCollapse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_BeginCollapse"), typeof(_SysGUI_BeginCollapse));
            }

            return _SysGUI_BeginCollapseFunc(label, text, open);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_EndCollapse();
         private static _SysGUI_EndCollapse _SysGUI_EndCollapseFunc;
         internal static int SysGUI_EndCollapse()
         {
            if (_SysGUI_EndCollapseFunc == null)
            {
               _SysGUI_EndCollapseFunc =
                  (_SysGUI_EndCollapse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_EndCollapse"), typeof(_SysGUI_EndCollapse));
            }

            return _SysGUI_EndCollapseFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_ColorWheel(string label, Color col);
         private static _SysGUI_ColorWheel _SysGUI_ColorWheelFunc;
         internal static int SysGUI_ColorWheel(string label, Color col)
         {
            if (_SysGUI_ColorWheelFunc == null)
            {
               _SysGUI_ColorWheelFunc =
                  (_SysGUI_ColorWheel)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_ColorWheel"), typeof(_SysGUI_ColorWheel));
            }

            return _SysGUI_ColorWheelFunc(label, col);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_Separator();
         private static _SysGUI_Separator _SysGUI_SeparatorFunc;
         internal static int SysGUI_Separator()
         {
            if (_SysGUI_SeparatorFunc == null)
            {
               _SysGUI_SeparatorFunc =
                  (_SysGUI_Separator)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_Separator"), typeof(_SysGUI_Separator));
            }

            return _SysGUI_SeparatorFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_Vector3(string label, Point3F vec3);
         private static _SysGUI_Vector3 _SysGUI_Vector3Func;
         internal static int SysGUI_Vector3(string label, Point3F vec3)
         {
            if (_SysGUI_Vector3Func == null)
            {
               _SysGUI_Vector3Func =
                  (_SysGUI_Vector3)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_Vector3"), typeof(_SysGUI_Vector3));
            }

            return _SysGUI_Vector3Func(label, vec3);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_Label(string label);
         private static _SysGUI_Label _SysGUI_LabelFunc;
         internal static int SysGUI_Label(string label)
         {
            if (_SysGUI_LabelFunc == null)
            {
               _SysGUI_LabelFunc =
                  (_SysGUI_Label)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_Label"), typeof(_SysGUI_Label));
            }

            return _SysGUI_LabelFunc(label);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_TextInput(string label, string text);
         private static _SysGUI_TextInput _SysGUI_TextInputFunc;
         internal static int SysGUI_TextInput(string label, string text)
         {
            if (_SysGUI_TextInputFunc == null)
            {
               _SysGUI_TextInputFunc =
                  (_SysGUI_TextInput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_TextInput"), typeof(_SysGUI_TextInput));
            }

            return _SysGUI_TextInputFunc(label, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_Button(string label, string text);
         private static _SysGUI_Button _SysGUI_ButtonFunc;
         internal static int SysGUI_Button(string label, string text)
         {
            if (_SysGUI_ButtonFunc == null)
            {
               _SysGUI_ButtonFunc =
                  (_SysGUI_Button)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_Button"), typeof(_SysGUI_Button));
            }

            return _SysGUI_ButtonFunc(label, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_CheckBox(string label, bool isChecked);
         private static _SysGUI_CheckBox _SysGUI_CheckBoxFunc;
         internal static int SysGUI_CheckBox(string label, bool isChecked)
         {
            if (_SysGUI_CheckBoxFunc == null)
            {
               _SysGUI_CheckBoxFunc =
                  (_SysGUI_CheckBox)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_CheckBox"), typeof(_SysGUI_CheckBox));
            }

            return _SysGUI_CheckBoxFunc(label, isChecked);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_Slider(string label, int value, int min, int max);
         private static _SysGUI_Slider _SysGUI_SliderFunc;
         internal static int SysGUI_Slider(string label, int value, int min, int max)
         {
            if (_SysGUI_SliderFunc == null)
            {
               _SysGUI_SliderFunc =
                  (_SysGUI_Slider)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_Slider"), typeof(_SysGUI_Slider));
            }

            return _SysGUI_SliderFunc(label, value, min, max);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SysGUI_GetLabelValue(int id);
         private static _SysGUI_GetLabelValue _SysGUI_GetLabelValueFunc;
         internal static IntPtr SysGUI_GetLabelValue(int id)
         {
            if (_SysGUI_GetLabelValueFunc == null)
            {
               _SysGUI_GetLabelValueFunc =
                  (_SysGUI_GetLabelValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_GetLabelValue"), typeof(_SysGUI_GetLabelValue));
            }

            return _SysGUI_GetLabelValueFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_SetLabelValue(int id, string val);
         private static _SysGUI_SetLabelValue _SysGUI_SetLabelValueFunc;
         internal static void SysGUI_SetLabelValue(int id, string val)
         {
            if (_SysGUI_SetLabelValueFunc == null)
            {
               _SysGUI_SetLabelValueFunc =
                  (_SysGUI_SetLabelValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_SetLabelValue"), typeof(_SysGUI_SetLabelValue));
            }

            _SysGUI_SetLabelValueFunc(id, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SysGUI_GetTextValue(int id);
         private static _SysGUI_GetTextValue _SysGUI_GetTextValueFunc;
         internal static IntPtr SysGUI_GetTextValue(int id)
         {
            if (_SysGUI_GetTextValueFunc == null)
            {
               _SysGUI_GetTextValueFunc =
                  (_SysGUI_GetTextValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_GetTextValue"), typeof(_SysGUI_GetTextValue));
            }

            return _SysGUI_GetTextValueFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_SetTextValue(int id, string val);
         private static _SysGUI_SetTextValue _SysGUI_SetTextValueFunc;
         internal static void SysGUI_SetTextValue(int id, string val)
         {
            if (_SysGUI_SetTextValueFunc == null)
            {
               _SysGUI_SetTextValueFunc =
                  (_SysGUI_SetTextValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_SetTextValue"), typeof(_SysGUI_SetTextValue));
            }

            _SysGUI_SetTextValueFunc(id, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_GetIntValue(int id);
         private static _SysGUI_GetIntValue _SysGUI_GetIntValueFunc;
         internal static int SysGUI_GetIntValue(int id)
         {
            if (_SysGUI_GetIntValueFunc == null)
            {
               _SysGUI_GetIntValueFunc =
                  (_SysGUI_GetIntValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_GetIntValue"), typeof(_SysGUI_GetIntValue));
            }

            return _SysGUI_GetIntValueFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SysGUI_GetBoolValue(int id);
         private static _SysGUI_GetBoolValue _SysGUI_GetBoolValueFunc;
         internal static bool SysGUI_GetBoolValue(int id)
         {
            if (_SysGUI_GetBoolValueFunc == null)
            {
               _SysGUI_GetBoolValueFunc =
                  (_SysGUI_GetBoolValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_GetBoolValue"), typeof(_SysGUI_GetBoolValue));
            }

            return _SysGUI_GetBoolValueFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_AlignLeft(int id);
         private static _SysGUI_AlignLeft _SysGUI_AlignLeftFunc;
         internal static void SysGUI_AlignLeft(int id)
         {
            if (_SysGUI_AlignLeftFunc == null)
            {
               _SysGUI_AlignLeftFunc =
                  (_SysGUI_AlignLeft)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_AlignLeft"), typeof(_SysGUI_AlignLeft));
            }

            _SysGUI_AlignLeftFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_AlignRight(int id);
         private static _SysGUI_AlignRight _SysGUI_AlignRightFunc;
         internal static void SysGUI_AlignRight(int id)
         {
            if (_SysGUI_AlignRightFunc == null)
            {
               _SysGUI_AlignRightFunc =
                  (_SysGUI_AlignRight)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_AlignRight"), typeof(_SysGUI_AlignRight));
            }

            _SysGUI_AlignRightFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_AlignTop(int id);
         private static _SysGUI_AlignTop _SysGUI_AlignTopFunc;
         internal static void SysGUI_AlignTop(int id)
         {
            if (_SysGUI_AlignTopFunc == null)
            {
               _SysGUI_AlignTopFunc =
                  (_SysGUI_AlignTop)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_AlignTop"), typeof(_SysGUI_AlignTop));
            }

            _SysGUI_AlignTopFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_AlignBottom(int id);
         private static _SysGUI_AlignBottom _SysGUI_AlignBottomFunc;
         internal static void SysGUI_AlignBottom(int id)
         {
            if (_SysGUI_AlignBottomFunc == null)
            {
               _SysGUI_AlignBottomFunc =
                  (_SysGUI_AlignBottom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_AlignBottom"), typeof(_SysGUI_AlignBottom));
            }

            _SysGUI_AlignBottomFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_List();
         private static _SysGUI_List _SysGUI_ListFunc;
         internal static int SysGUI_List()
         {
            if (_SysGUI_ListFunc == null)
            {
               _SysGUI_ListFunc =
                  (_SysGUI_List)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_List"), typeof(_SysGUI_List));
            }

            return _SysGUI_ListFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_AddListValue(int id, string value);
         private static _SysGUI_AddListValue _SysGUI_AddListValueFunc;
         internal static void SysGUI_AddListValue(int id, string value)
         {
            if (_SysGUI_AddListValueFunc == null)
            {
               _SysGUI_AddListValueFunc =
                  (_SysGUI_AddListValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_AddListValue"), typeof(_SysGUI_AddListValue));
            }

            _SysGUI_AddListValueFunc(id, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SysGUI_GetListValue(int id, int idx);
         private static _SysGUI_GetListValue _SysGUI_GetListValueFunc;
         internal static IntPtr SysGUI_GetListValue(int id, int idx)
         {
            if (_SysGUI_GetListValueFunc == null)
            {
               _SysGUI_GetListValueFunc =
                  (_SysGUI_GetListValue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_GetListValue"), typeof(_SysGUI_GetListValue));
            }

            return _SysGUI_GetListValueFunc(id, idx);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SysGUI_GetListSelected(int id);
         private static _SysGUI_GetListSelected _SysGUI_GetListSelectedFunc;
         internal static int SysGUI_GetListSelected(int id)
         {
            if (_SysGUI_GetListSelectedFunc == null)
            {
               _SysGUI_GetListSelectedFunc =
                  (_SysGUI_GetListSelected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_GetListSelected"), typeof(_SysGUI_GetListSelected));
            }

            return _SysGUI_GetListSelectedFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_ClearList(int id);
         private static _SysGUI_ClearList _SysGUI_ClearListFunc;
         internal static void SysGUI_ClearList(int id)
         {
            if (_SysGUI_ClearListFunc == null)
            {
               _SysGUI_ClearListFunc =
                  (_SysGUI_ClearList)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_ClearList"), typeof(_SysGUI_ClearList));
            }

            _SysGUI_ClearListFunc(id);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SysGUI_SetElementHidden(int id, bool hidden);
         private static _SysGUI_SetElementHidden _SysGUI_SetElementHiddenFunc;
         internal static void SysGUI_SetElementHidden(int id, bool hidden)
         {
            if (_SysGUI_SetElementHiddenFunc == null)
            {
               _SysGUI_SetElementHiddenFunc =
                  (_SysGUI_SetElementHidden)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SysGUI_SetElementHidden"), typeof(_SysGUI_SetElementHidden));
            }

            _SysGUI_SetElementHiddenFunc(id, hidden);
         }
      }

      #endregion
      
      #region Functions

      public static void SetEnabled(bool enable)
      {
         InternalUnsafeMethods.SysGUI_SetEnabled(enable);
      }

      public static int BeginScrollArea(string title, uint x, uint y, uint width, uint height)
      {
         return InternalUnsafeMethods.SysGUI_BeginScrollArea(title, x, y, width, height);
      }

      public static int EndScrollArea()
      {
         return InternalUnsafeMethods.SysGUI_EndScrollArea();
      }

      public static int BeginCollapse(string label, string text, bool open)
      {
         return InternalUnsafeMethods.SysGUI_BeginCollapse(label, text, open);
      }

      public static int EndCollapse()
      {
         return InternalUnsafeMethods.SysGUI_EndCollapse();
      }

      public static int ColorWheel(string label, Color col)
      {
         return InternalUnsafeMethods.SysGUI_ColorWheel(label, col);
      }

      public static int Separator()
      {
         return InternalUnsafeMethods.SysGUI_Separator();
      }

      public static int Vector3(string label, Point3F vec3)
      {
         return InternalUnsafeMethods.SysGUI_Vector3(label, vec3);
      }

      public static int Label(string label)
      {
         return InternalUnsafeMethods.SysGUI_Label(label);
      }

      public static int TextInput(string label, string text)
      {
         return InternalUnsafeMethods.SysGUI_TextInput(label, text);
      }

      public static int Button(string label, string text)
      {
         return InternalUnsafeMethods.SysGUI_Button(label, text);
      }

      public static int CheckBox(string label, bool isChecked)
      {
         return InternalUnsafeMethods.SysGUI_CheckBox(label, isChecked);
      }

      public static int Slider(string label, int value, int min, int max)
      {
         return InternalUnsafeMethods.SysGUI_Slider(label, value, min, max);
      }

      public static string GetLabelValue(int id)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SysGUI_GetLabelValue(id));
      }

      public static void SetLabelValue(int id, string val)
      {
         InternalUnsafeMethods.SysGUI_SetLabelValue(id, val);
      }

      public static string GetTextValue(int id)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SysGUI_GetTextValue(id));
      }

      public static void SetTextValue(int id, string val)
      {
         InternalUnsafeMethods.SysGUI_SetTextValue(id, val);
      }

      public static int GetIntValue(int id)
      {
         return InternalUnsafeMethods.SysGUI_GetIntValue(id);
      }

      public static bool GetBoolValue(int id)
      {
         return InternalUnsafeMethods.SysGUI_GetBoolValue(id);
      }

      public static void AlignLeft(int id)
      {
         InternalUnsafeMethods.SysGUI_AlignLeft(id);
      }

      public static void AlignRight(int id)
      {
         InternalUnsafeMethods.SysGUI_AlignRight(id);
      }

      public static void AlignTop(int id)
      {
         InternalUnsafeMethods.SysGUI_AlignTop(id);
      }

      public static void AlignBottom(int id)
      {
         InternalUnsafeMethods.SysGUI_AlignBottom(id);
      }

      public static int List()
      {
         return InternalUnsafeMethods.SysGUI_List();
      }

      public static void AddListValue(int id, string value)
      {
         InternalUnsafeMethods.SysGUI_AddListValue(id, value);
      }

      public static string GetListValue(int id, int idx)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.SysGUI_GetListValue(id, idx));
      }

      public static int GetListSelected(int id)
      {
         return InternalUnsafeMethods.SysGUI_GetListSelected(id);
      }

      public static void ClearList(int id)
      {
         InternalUnsafeMethods.SysGUI_ClearList(id);
      }

      public static void SetElementHidden(int id, bool hidden)
      {
         InternalUnsafeMethods.SysGUI_SetElementHidden(id, hidden);
      }      

      #endregion
   }
}