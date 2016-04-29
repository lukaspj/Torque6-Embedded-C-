using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class BehaviorTemplate : SimObject
   {
      
      public BehaviorTemplate()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.BehaviorTemplateCreateInstance());
      }

      public BehaviorTemplate(uint pId) : base(pId)
      {
      }

      public BehaviorTemplate(string pName) : base(pName)
      {
      }

      public BehaviorTemplate(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public BehaviorTemplate(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public BehaviorTemplate(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateGetFriendlyName(IntPtr instance);
         private static _BehaviorTemplateGetFriendlyName _BehaviorTemplateGetFriendlyNameFunc;
         internal static IntPtr BehaviorTemplateGetFriendlyName(IntPtr instance)
         {
            if (_BehaviorTemplateGetFriendlyNameFunc == null)
            {
               _BehaviorTemplateGetFriendlyNameFunc =
                  (_BehaviorTemplateGetFriendlyName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetFriendlyName"), typeof(_BehaviorTemplateGetFriendlyName));
            }

            return _BehaviorTemplateGetFriendlyNameFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _BehaviorTemplateSetFriendlyName(IntPtr instance, string name);
         private static _BehaviorTemplateSetFriendlyName _BehaviorTemplateSetFriendlyNameFunc;
         internal static void BehaviorTemplateSetFriendlyName(IntPtr instance, string name)
         {
            if (_BehaviorTemplateSetFriendlyNameFunc == null)
            {
               _BehaviorTemplateSetFriendlyNameFunc =
                  (_BehaviorTemplateSetFriendlyName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateSetFriendlyName"), typeof(_BehaviorTemplateSetFriendlyName));
            }

            _BehaviorTemplateSetFriendlyNameFunc(instance, name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateGetDescription(IntPtr instance);
         private static _BehaviorTemplateGetDescription _BehaviorTemplateGetDescriptionFunc;
         internal static IntPtr BehaviorTemplateGetDescription(IntPtr instance)
         {
            if (_BehaviorTemplateGetDescriptionFunc == null)
            {
               _BehaviorTemplateGetDescriptionFunc =
                  (_BehaviorTemplateGetDescription)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetDescription"), typeof(_BehaviorTemplateGetDescription));
            }

            return _BehaviorTemplateGetDescriptionFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _BehaviorTemplateSetDescription(IntPtr instance, string description);
         private static _BehaviorTemplateSetDescription _BehaviorTemplateSetDescriptionFunc;
         internal static void BehaviorTemplateSetDescription(IntPtr instance, string description)
         {
            if (_BehaviorTemplateSetDescriptionFunc == null)
            {
               _BehaviorTemplateSetDescriptionFunc =
                  (_BehaviorTemplateSetDescription)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateSetDescription"), typeof(_BehaviorTemplateSetDescription));
            }

            _BehaviorTemplateSetDescriptionFunc(instance, description);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateGetBehaviorType(IntPtr instance);
         private static _BehaviorTemplateGetBehaviorType _BehaviorTemplateGetBehaviorTypeFunc;
         internal static IntPtr BehaviorTemplateGetBehaviorType(IntPtr instance)
         {
            if (_BehaviorTemplateGetBehaviorTypeFunc == null)
            {
               _BehaviorTemplateGetBehaviorTypeFunc =
                  (_BehaviorTemplateGetBehaviorType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetBehaviorType"), typeof(_BehaviorTemplateGetBehaviorType));
            }

            return _BehaviorTemplateGetBehaviorTypeFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _BehaviorTemplateSetBehaviorType(IntPtr instance, string type);
         private static _BehaviorTemplateSetBehaviorType _BehaviorTemplateSetBehaviorTypeFunc;
         internal static void BehaviorTemplateSetBehaviorType(IntPtr instance, string type)
         {
            if (_BehaviorTemplateSetBehaviorTypeFunc == null)
            {
               _BehaviorTemplateSetBehaviorTypeFunc =
                  (_BehaviorTemplateSetBehaviorType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateSetBehaviorType"), typeof(_BehaviorTemplateSetBehaviorType));
            }

            _BehaviorTemplateSetBehaviorTypeFunc(instance, type);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateCreateInstance();
         private static _BehaviorTemplateCreateInstance _BehaviorTemplateCreateInstanceFunc;
         internal static IntPtr BehaviorTemplateCreateInstance()
         {
            if (_BehaviorTemplateCreateInstanceFunc == null)
            {
               _BehaviorTemplateCreateInstanceFunc =
                  (_BehaviorTemplateCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateCreateInstance"), typeof(_BehaviorTemplateCreateInstance));
            }

            return _BehaviorTemplateCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateCreateBehaviorInstance(IntPtr instance);
         private static _BehaviorTemplateCreateBehaviorInstance _BehaviorTemplateCreateBehaviorInstanceFunc;
         internal static IntPtr BehaviorTemplateCreateBehaviorInstance(IntPtr instance)
         {
            if (_BehaviorTemplateCreateBehaviorInstanceFunc == null)
            {
               _BehaviorTemplateCreateBehaviorInstanceFunc =
                  (_BehaviorTemplateCreateBehaviorInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateCreateBehaviorInstance"), typeof(_BehaviorTemplateCreateBehaviorInstance));
            }

            return _BehaviorTemplateCreateBehaviorInstanceFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorTemplateAddBehaviorField(IntPtr instance, string fieldName, string desc, string type, string defaultValue, string userData);
         private static _BehaviorTemplateAddBehaviorField _BehaviorTemplateAddBehaviorFieldFunc;
         internal static bool BehaviorTemplateAddBehaviorField(IntPtr instance, string fieldName, string desc, string type, string defaultValue, string userData)
         {
            if (_BehaviorTemplateAddBehaviorFieldFunc == null)
            {
               _BehaviorTemplateAddBehaviorFieldFunc =
                  (_BehaviorTemplateAddBehaviorField)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateAddBehaviorField"), typeof(_BehaviorTemplateAddBehaviorField));
            }

            return _BehaviorTemplateAddBehaviorFieldFunc(instance, fieldName, desc, type, defaultValue, userData);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _BehaviorTemplateGetBehaviorFieldCount(IntPtr instance);
         private static _BehaviorTemplateGetBehaviorFieldCount _BehaviorTemplateGetBehaviorFieldCountFunc;
         internal static int BehaviorTemplateGetBehaviorFieldCount(IntPtr instance)
         {
            if (_BehaviorTemplateGetBehaviorFieldCountFunc == null)
            {
               _BehaviorTemplateGetBehaviorFieldCountFunc =
                  (_BehaviorTemplateGetBehaviorFieldCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetBehaviorFieldCount"), typeof(_BehaviorTemplateGetBehaviorFieldCount));
            }

            return _BehaviorTemplateGetBehaviorFieldCountFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateGetBehaviorField(IntPtr instance, int fieldIndex);
         private static _BehaviorTemplateGetBehaviorField _BehaviorTemplateGetBehaviorFieldFunc;
         internal static IntPtr BehaviorTemplateGetBehaviorField(IntPtr instance, int fieldIndex)
         {
            if (_BehaviorTemplateGetBehaviorFieldFunc == null)
            {
               _BehaviorTemplateGetBehaviorFieldFunc =
                  (_BehaviorTemplateGetBehaviorField)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetBehaviorField"), typeof(_BehaviorTemplateGetBehaviorField));
            }

            return _BehaviorTemplateGetBehaviorFieldFunc(instance, fieldIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateGetBehaviorFieldUserData(IntPtr instance, int fieldIndex);
         private static _BehaviorTemplateGetBehaviorFieldUserData _BehaviorTemplateGetBehaviorFieldUserDataFunc;
         internal static IntPtr BehaviorTemplateGetBehaviorFieldUserData(IntPtr instance, int fieldIndex)
         {
            if (_BehaviorTemplateGetBehaviorFieldUserDataFunc == null)
            {
               _BehaviorTemplateGetBehaviorFieldUserDataFunc =
                  (_BehaviorTemplateGetBehaviorFieldUserData)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetBehaviorFieldUserData"), typeof(_BehaviorTemplateGetBehaviorFieldUserData));
            }

            return _BehaviorTemplateGetBehaviorFieldUserDataFunc(instance, fieldIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateGetBehaviorFieldDescription(IntPtr instance, int fieldIndex);
         private static _BehaviorTemplateGetBehaviorFieldDescription _BehaviorTemplateGetBehaviorFieldDescriptionFunc;
         internal static IntPtr BehaviorTemplateGetBehaviorFieldDescription(IntPtr instance, int fieldIndex)
         {
            if (_BehaviorTemplateGetBehaviorFieldDescriptionFunc == null)
            {
               _BehaviorTemplateGetBehaviorFieldDescriptionFunc =
                  (_BehaviorTemplateGetBehaviorFieldDescription)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetBehaviorFieldDescription"), typeof(_BehaviorTemplateGetBehaviorFieldDescription));
            }

            return _BehaviorTemplateGetBehaviorFieldDescriptionFunc(instance, fieldIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorTemplateAddBehaviorOutput(IntPtr instance, string outputName, string label, string description);
         private static _BehaviorTemplateAddBehaviorOutput _BehaviorTemplateAddBehaviorOutputFunc;
         internal static bool BehaviorTemplateAddBehaviorOutput(IntPtr instance, string outputName, string label, string description)
         {
            if (_BehaviorTemplateAddBehaviorOutputFunc == null)
            {
               _BehaviorTemplateAddBehaviorOutputFunc =
                  (_BehaviorTemplateAddBehaviorOutput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateAddBehaviorOutput"), typeof(_BehaviorTemplateAddBehaviorOutput));
            }

            return _BehaviorTemplateAddBehaviorOutputFunc(instance, outputName, label, description);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _BehaviorTemplateGetBehaviorOutputCount(IntPtr instance);
         private static _BehaviorTemplateGetBehaviorOutputCount _BehaviorTemplateGetBehaviorOutputCountFunc;
         internal static int BehaviorTemplateGetBehaviorOutputCount(IntPtr instance)
         {
            if (_BehaviorTemplateGetBehaviorOutputCountFunc == null)
            {
               _BehaviorTemplateGetBehaviorOutputCountFunc =
                  (_BehaviorTemplateGetBehaviorOutputCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetBehaviorOutputCount"), typeof(_BehaviorTemplateGetBehaviorOutputCount));
            }

            return _BehaviorTemplateGetBehaviorOutputCountFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateGetBehaviorOutput(IntPtr instance, int fieldIndex);
         private static _BehaviorTemplateGetBehaviorOutput _BehaviorTemplateGetBehaviorOutputFunc;
         internal static IntPtr BehaviorTemplateGetBehaviorOutput(IntPtr instance, int fieldIndex)
         {
            if (_BehaviorTemplateGetBehaviorOutputFunc == null)
            {
               _BehaviorTemplateGetBehaviorOutputFunc =
                  (_BehaviorTemplateGetBehaviorOutput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetBehaviorOutput"), typeof(_BehaviorTemplateGetBehaviorOutput));
            }

            return _BehaviorTemplateGetBehaviorOutputFunc(instance, fieldIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorTemplateHasBehaviorOutput(IntPtr instance, string outputName);
         private static _BehaviorTemplateHasBehaviorOutput _BehaviorTemplateHasBehaviorOutputFunc;
         internal static bool BehaviorTemplateHasBehaviorOutput(IntPtr instance, string outputName)
         {
            if (_BehaviorTemplateHasBehaviorOutputFunc == null)
            {
               _BehaviorTemplateHasBehaviorOutputFunc =
                  (_BehaviorTemplateHasBehaviorOutput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateHasBehaviorOutput"), typeof(_BehaviorTemplateHasBehaviorOutput));
            }

            return _BehaviorTemplateHasBehaviorOutputFunc(instance, outputName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorTemplateAddBehaviorInput(IntPtr instance, string inputName, string label, string description);
         private static _BehaviorTemplateAddBehaviorInput _BehaviorTemplateAddBehaviorInputFunc;
         internal static bool BehaviorTemplateAddBehaviorInput(IntPtr instance, string inputName, string label, string description)
         {
            if (_BehaviorTemplateAddBehaviorInputFunc == null)
            {
               _BehaviorTemplateAddBehaviorInputFunc =
                  (_BehaviorTemplateAddBehaviorInput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateAddBehaviorInput"), typeof(_BehaviorTemplateAddBehaviorInput));
            }

            return _BehaviorTemplateAddBehaviorInputFunc(instance, inputName, label, description);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _BehaviorTemplateGetBehaviorInputCount(IntPtr instance);
         private static _BehaviorTemplateGetBehaviorInputCount _BehaviorTemplateGetBehaviorInputCountFunc;
         internal static int BehaviorTemplateGetBehaviorInputCount(IntPtr instance)
         {
            if (_BehaviorTemplateGetBehaviorInputCountFunc == null)
            {
               _BehaviorTemplateGetBehaviorInputCountFunc =
                  (_BehaviorTemplateGetBehaviorInputCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetBehaviorInputCount"), typeof(_BehaviorTemplateGetBehaviorInputCount));
            }

            return _BehaviorTemplateGetBehaviorInputCountFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BehaviorTemplateGetBehaviorInput(IntPtr instance, int fieldIndex);
         private static _BehaviorTemplateGetBehaviorInput _BehaviorTemplateGetBehaviorInputFunc;
         internal static IntPtr BehaviorTemplateGetBehaviorInput(IntPtr instance, int fieldIndex)
         {
            if (_BehaviorTemplateGetBehaviorInputFunc == null)
            {
               _BehaviorTemplateGetBehaviorInputFunc =
                  (_BehaviorTemplateGetBehaviorInput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateGetBehaviorInput"), typeof(_BehaviorTemplateGetBehaviorInput));
            }

            return _BehaviorTemplateGetBehaviorInputFunc(instance, fieldIndex);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _BehaviorTemplateHasBehaviorInput(IntPtr instance, string inputName);
         private static _BehaviorTemplateHasBehaviorInput _BehaviorTemplateHasBehaviorInputFunc;
         internal static bool BehaviorTemplateHasBehaviorInput(IntPtr instance, string inputName)
         {
            if (_BehaviorTemplateHasBehaviorInputFunc == null)
            {
               _BehaviorTemplateHasBehaviorInputFunc =
                  (_BehaviorTemplateHasBehaviorInput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "BehaviorTemplateHasBehaviorInput"), typeof(_BehaviorTemplateHasBehaviorInput));
            }

            return _BehaviorTemplateHasBehaviorInputFunc(instance, inputName);
         }
      }
      
      #endregion

      #region Properties

      public string FriendlyName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorTemplateGetFriendlyName(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.BehaviorTemplateSetFriendlyName(ObjectPtr->ObjPtr, value);
         }
      }
      public string Description
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorTemplateGetDescription(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.BehaviorTemplateSetDescription(ObjectPtr->ObjPtr, value);
         }
      }
      public string BehaviorType
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorTemplateGetBehaviorType(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.BehaviorTemplateSetBehaviorType(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public BehaviorInstance CreateBehaviorInstance()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new BehaviorInstance(InternalUnsafeMethods.BehaviorTemplateCreateBehaviorInstance(ObjectPtr->ObjPtr));
      }

      public bool AddBehaviorField(string fieldName, string desc, string type, string defaultValue = null, string userData = null)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorTemplateAddBehaviorField(ObjectPtr->ObjPtr, fieldName, desc, type, defaultValue, userData);
      }

      public int GetBehaviorFieldCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorTemplateGetBehaviorFieldCount(ObjectPtr->ObjPtr);
      }

      public string GetBehaviorField(int fieldIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorTemplateGetBehaviorField(ObjectPtr->ObjPtr, fieldIndex));
      }

      public string GetBehaviorFieldUserData(int fieldIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorTemplateGetBehaviorFieldUserData(ObjectPtr->ObjPtr, fieldIndex));
      }

      public string GetBehaviorFieldDescription(int fieldIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorTemplateGetBehaviorFieldDescription(ObjectPtr->ObjPtr, fieldIndex));
      }

      public bool AddBehaviorOutput(string outputName, string label, string description)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorTemplateAddBehaviorOutput(ObjectPtr->ObjPtr, outputName, label, description);
      }

      public int GetBehaviorOutputCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorTemplateGetBehaviorOutputCount(ObjectPtr->ObjPtr);
      }

      public string GetBehaviorOutput(int fieldIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorTemplateGetBehaviorOutput(ObjectPtr->ObjPtr, fieldIndex));
      }

      public bool HasBehaviorOutput(string outputName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorTemplateHasBehaviorOutput(ObjectPtr->ObjPtr, outputName);
      }

      public bool AddBehaviorInput(string inputName, string label, string description)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorTemplateAddBehaviorInput(ObjectPtr->ObjPtr, inputName, label, description);
      }

      public int GetBehaviorInputCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorTemplateGetBehaviorInputCount(ObjectPtr->ObjPtr);
      }

      public string GetBehaviorInput(int fieldIndex)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.BehaviorTemplateGetBehaviorInput(ObjectPtr->ObjPtr, fieldIndex));
      }

      public bool HasBehaviorInput(string inputName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.BehaviorTemplateHasBehaviorInput(ObjectPtr->ObjPtr, inputName);
      }
      
      #endregion

      
   }
}