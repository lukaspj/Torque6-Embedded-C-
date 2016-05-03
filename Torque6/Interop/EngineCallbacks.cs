using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Torque6.Engine.SimObjects;

namespace Torque6.Interop
{
   internal class EngineCallbacks
   {
      private static readonly Dictionary<string, Type> ClassTypeDictionary = new Dictionary<string, Type>();
      private static readonly Dictionary<string, MethodInfo> FunctionDictionary = new Dictionary<string, MethodInfo>();
      private static readonly Dictionary<uint, SimObject> ObjectDictionary = new Dictionary<uint, SimObject>();

      public static void RegisterType(string className, Type classType)
      {
         ClassTypeDictionary.Add(className, classType);
      }

      public static void RegisterFunction(string functionName, MethodInfo methodInfo)
      {
         FunctionDictionary.Add(functionName, methodInfo);
      }

      public static void Clear()
      {
         ClassTypeDictionary.Clear();
         FunctionDictionary.Clear();
      }

      public static string CallScriptFunction(string pFunctionName, object[] args, out bool found)
      {
         if (!FunctionDictionary.ContainsKey(pFunctionName))
         {
            found = false;
            return null;
         }
         found = true;
         MethodInfo methodInfo = FunctionDictionary[pFunctionName];
         if (methodInfo.ReturnType == typeof (string))
            return (string) methodInfo.Invoke(null, args);
         methodInfo.Invoke(null, args);
         return null;
      }

      public static string CallScriptMethod(string className, SimObject objectWrapper, string methodName, object[] args,
         out bool found)
      {
         Type type;
         string objectName = objectWrapper.GetName();
         if (objectName != null && ClassTypeDictionary.ContainsKey(objectName))
         {
            type = ClassTypeDictionary[objectName];
         } else if (ClassTypeDictionary.ContainsKey(className))
         {
            type = ClassTypeDictionary[className];
         }
         else
         {
            //todo throw exception?
            found = false;
            return null;
         }
         MethodInfo callbackMethod = type.GetMethod(methodName);
         if (callbackMethod != null)
         {
            found = true;
            object simObj = null;
            if (!callbackMethod.IsStatic)
               simObj = CreateInstance(type, objectWrapper);
            if (callbackMethod.ReturnType == typeof (string))
               return (string) callbackMethod.Invoke(simObj, args);
            callbackMethod.Invoke(simObj, args);
            return null;
         }
         found = false;
         return null;
      }

      private static object CreateInstance(Type type, SimObject objectWrapper)
      {
         if (!ObjectDictionary.ContainsKey(objectWrapper.GetID()))
         {
            SimObject obj = (SimObject)FormatterServices.GetUninitializedObject(type);
            obj.SetPointerFromObject(objectWrapper);
            ObjectDictionary[objectWrapper.GetID()] = obj;
         }
         return ObjectDictionary[objectWrapper.GetID()];
      }

      public static bool IsMethod(string className, string methodName)
      {
         if (!ClassTypeDictionary.ContainsKey(className))
            return false;
         return ClassTypeDictionary[className].GetMethod(methodName) != null;
      }
   }
}