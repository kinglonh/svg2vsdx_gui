using System;
using System.Reflection;

	public class VisioComObj
	{
		public static VisioComObj Create(string progId)
		{
			var type = Type.GetTypeFromProgID(progId);
			if (type == null)
			{
				throw new Exception("服务器需要安装" + progId + "才能使用此功能");
			}
			return new VisioComObj(Activator.CreateInstance(type));
		}

		private object _val;

		public object Val
		{
			get { return _val; }
		}

		public VisioComObj(object comObject)
		{
			_val = comObject;
		}

		public VisioComObj Call(string method, params object[] args)
		{
			if (_val == null)
				return null;
			var ret = _val.GetType().InvokeMember(method, BindingFlags.InvokeMethod, null, _val, args);
			return new VisioComObj(ret);
		}

		public VisioComObj this[string property]
		{
			get
			{
				if (_val == null)
					return null;
				var ret = _val.GetType().InvokeMember(property, BindingFlags.GetProperty, null, _val, null);
				return new VisioComObj(ret);
			}
			set
			{
				if (_val != null)
					_val.GetType().InvokeMember(property, BindingFlags.SetProperty, null, _val, new object[] { value._val });
			}
		}

	public static void Svg2Vsd(string svgFn, string desVsdFn)
	{
		var app = VisioComObj.Create("Visio.Application");
		try
		{
			app["Visible"] = new VisioComObj(false);
			var docs = app["Documents"];
			short visOpenHidden = 64, visOpenRO = 2;
			var doc = docs.Call("OpenEx", svgFn, visOpenHidden + visOpenRO);
			doc.Call("SaveAs", desVsdFn);
			doc.Call("Close");
		}
		finally
		{
			app.Call("Quit");
		}
	}
}

