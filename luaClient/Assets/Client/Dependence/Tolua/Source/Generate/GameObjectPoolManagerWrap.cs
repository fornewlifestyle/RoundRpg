﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GameObjectPoolManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GameObjectPoolManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetGameObjectDirect", GetGameObjectDirect);
		L.RegFunction("GetGameObjectAsync", GetGameObjectAsync);
		L.RegFunction("IsGameObjectCached", IsGameObjectCached);
		L.RegFunction("Regist", Regist);
		L.RegFunction("Spawn", Spawn);
		L.RegFunction("UnRegist", UnRegist);
		L.RegFunction("CreateGameObjectPool", CreateGameObjectPool);
		L.RegFunction("Unspawn", Unspawn);
		L.RegFunction("UnspawnAndDestory", UnspawnAndDestory);
		L.RegFunction("DestoryGameObjectPool", DestoryGameObjectPool);
		L.RegFunction("TryGetPoolId", TryGetPoolId);
		L.RegFunction("ReducePoolSize", ReducePoolSize);
		L.RegFunction("Release", Release);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("gameObjectPools", get_gameObjectPools, set_gameObjectPools);
		L.RegVar("resourcePools", get_resourcePools, set_resourcePools);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGameObjectDirect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.GameObject o = obj.GetGameObjectDirect(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGameObjectAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			string arg0 = ToLua.CheckString(L, 2);
			Void_UnityEngineObject arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Void_UnityEngineObject)ToLua.CheckObject(L, 3, typeof(Void_UnityEngineObject));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(Void_UnityEngineObject), func) as Void_UnityEngineObject;
			}

			obj.GetGameObjectAsync(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsGameObjectCached(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.IsGameObjectCached(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Regist(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			string arg0 = ToLua.CheckString(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.Regist(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Spawn(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.GameObject o = obj.Spawn(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnRegist(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			string arg0 = ToLua.CheckString(L, 2);
			obj.UnRegist(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateGameObjectPool(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.CreateGameObjectPool(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unspawn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(GameObjectPoolManager), typeof(UnityEngine.GameObject)))
			{
				GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.ToObject(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 2);
				obj.Unspawn(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(GameObjectPoolManager), typeof(UnityEngine.GameObject), typeof(float)))
			{
				GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.ToObject(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				obj.Unspawn(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: GameObjectPoolManager.Unspawn");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnspawnAndDestory(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(GameObjectPoolManager), typeof(UnityEngine.GameObject)))
			{
				GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.ToObject(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 2);
				obj.UnspawnAndDestory(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(GameObjectPoolManager), typeof(UnityEngine.GameObject), typeof(float)))
			{
				GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.ToObject(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				obj.UnspawnAndDestory(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: GameObjectPoolManager.UnspawnAndDestory");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestoryGameObjectPool(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.DestoryGameObjectPool(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TryGetPoolId(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			int arg1;
			bool o = obj.TryGetPoolId(arg0, out arg1);
			LuaDLL.lua_pushboolean(L, o);
			LuaDLL.lua_pushinteger(L, arg1);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReducePoolSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			obj.ReducePoolSize();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Release(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameObjectPoolManager obj = (GameObjectPoolManager)ToLua.CheckObject(L, 1, typeof(GameObjectPoolManager));
			obj.Release();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameObjectPools(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameObjectPoolManager obj = (GameObjectPoolManager)o;
			System.Collections.Generic.Dictionary<int,GameObjectPool> ret = obj.gameObjectPools;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index gameObjectPools on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resourcePools(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameObjectPoolManager obj = (GameObjectPoolManager)o;
			System.Collections.Generic.Dictionary<string,AssetCounter> ret = obj.resourcePools;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index resourcePools on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, GameObjectPoolManager.Instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_gameObjectPools(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameObjectPoolManager obj = (GameObjectPoolManager)o;
			System.Collections.Generic.Dictionary<int,GameObjectPool> arg0 = (System.Collections.Generic.Dictionary<int,GameObjectPool>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<int,GameObjectPool>));
			obj.gameObjectPools = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index gameObjectPools on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resourcePools(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameObjectPoolManager obj = (GameObjectPoolManager)o;
			System.Collections.Generic.Dictionary<string,AssetCounter> arg0 = (System.Collections.Generic.Dictionary<string,AssetCounter>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.Dictionary<string,AssetCounter>));
			obj.resourcePools = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index resourcePools on a nil value" : e.Message);
		}
	}
}

