﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_ToggleWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.Toggle), typeof(UnityEngine.UI.Selectable));
		L.RegFunction("Rebuild", Rebuild);
		L.RegFunction("LayoutComplete", LayoutComplete);
		L.RegFunction("GraphicUpdateComplete", GraphicUpdateComplete);
		L.RegFunction("OnPointerClick", OnPointerClick);
		L.RegFunction("OnSubmit", OnSubmit);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("toggleTransition", get_toggleTransition, set_toggleTransition);
		L.RegVar("graphic", get_graphic, set_graphic);
		L.RegVar("onValueChanged", get_onValueChanged, set_onValueChanged);
		L.RegVar("group", get_group, set_group);
		L.RegVar("isOn", get_isOn, set_isOn);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebuild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Toggle));
			UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.CanvasUpdate));
			obj.Rebuild(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LayoutComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Toggle));
			obj.LayoutComplete();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GraphicUpdateComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Toggle));
			obj.GraphicUpdateComplete();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Toggle));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSubmit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Toggle));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnSubmit(arg0);
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
	static int get_toggleTransition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			UnityEngine.UI.Toggle.ToggleTransition ret = obj.toggleTransition;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index toggleTransition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_graphic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			UnityEngine.UI.Graphic ret = obj.graphic;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index graphic on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onValueChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			UnityEngine.UI.Toggle.ToggleEvent ret = obj.onValueChanged;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onValueChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_group(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			UnityEngine.UI.ToggleGroup ret = obj.group;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index group on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isOn(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			bool ret = obj.isOn;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index isOn on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_toggleTransition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			UnityEngine.UI.Toggle.ToggleTransition arg0 = (UnityEngine.UI.Toggle.ToggleTransition)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.Toggle.ToggleTransition));
			obj.toggleTransition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index toggleTransition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_graphic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			UnityEngine.UI.Graphic arg0 = (UnityEngine.UI.Graphic)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Graphic));
			obj.graphic = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index graphic on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onValueChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			UnityEngine.UI.Toggle.ToggleEvent arg0 = (UnityEngine.UI.Toggle.ToggleEvent)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.Toggle.ToggleEvent));
			obj.onValueChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onValueChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_group(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			UnityEngine.UI.ToggleGroup arg0 = (UnityEngine.UI.ToggleGroup)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.ToggleGroup));
			obj.group = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index group on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isOn(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Toggle obj = (UnityEngine.UI.Toggle)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.isOn = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index isOn on a nil value" : e.Message);
		}
	}
}

