using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Softwareexpress.Sitef {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']"
	[global::Android.Runtime.Register ("br/com/softwareexpress/sitef/JCliSiTefI", DoNotGenerateAcw=true)]
	public partial class JCliSiTefI : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("br/com/softwareexpress/sitef/JCliSiTefI", typeof (JCliSiTefI));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected JCliSiTefI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/constructor[@name='JCliSiTefI' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JCliSiTefI ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Buffer);
		}
#pragma warning restore 0169

		static Delegate cb_setBuffer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBuffer_Ljava_lang_String_Handler ()
		{
			if (cb_setBuffer_Ljava_lang_String_ == null)
				cb_setBuffer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBuffer_Ljava_lang_String_);
			return cb_setBuffer_Ljava_lang_String_;
		}

		static void n_SetBuffer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Buffer = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getBuffer' and count(parameter)=0]"
			[Register ("getBuffer", "()Ljava/lang/String;", "GetGetBufferHandler")]
			get {
				const string __id = "getBuffer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setBuffer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBuffer", "(Ljava/lang/String;)V", "GetSetBuffer_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBuffer.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCampo;
#pragma warning disable 0169
		static Delegate GetGetCampoHandler ()
		{
			if (cb_getCampo == null)
				cb_getCampo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCampo);
			return cb_getCampo;
		}

		static IntPtr n_GetCampo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Campo);
		}
#pragma warning restore 0169

		public virtual unsafe string Campo {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getCampo' and count(parameter)=0]"
			[Register ("getCampo", "()Ljava/lang/String;", "GetGetCampoHandler")]
			get {
				const string __id = "getCampo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChaveSeguranca;
#pragma warning disable 0169
		static Delegate GetGetChaveSegurancaHandler ()
		{
			if (cb_getChaveSeguranca == null)
				cb_getChaveSeguranca = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChaveSeguranca);
			return cb_getChaveSeguranca;
		}

		static IntPtr n_GetChaveSeguranca (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChaveSeguranca);
		}
#pragma warning restore 0169

		static Delegate cb_setChaveSeguranca_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveSeguranca_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveSeguranca_Ljava_lang_String_ == null)
				cb_setChaveSeguranca_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChaveSeguranca_Ljava_lang_String_);
			return cb_setChaveSeguranca_Ljava_lang_String_;
		}

		static void n_SetChaveSeguranca_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChaveSeguranca = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChaveSeguranca {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getChaveSeguranca' and count(parameter)=0]"
			[Register ("getChaveSeguranca", "()Ljava/lang/String;", "GetGetChaveSegurancaHandler")]
			get {
				const string __id = "getChaveSeguranca.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setChaveSeguranca' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChaveSeguranca", "(Ljava/lang/String;)V", "GetSetChaveSeguranca_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChaveSeguranca.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCodigoResposta;
#pragma warning disable 0169
		static Delegate GetGetCodigoRespostaHandler ()
		{
			if (cb_getCodigoResposta == null)
				cb_getCodigoResposta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetCodigoResposta);
			return cb_getCodigoResposta;
		}

		static short n_GetCodigoResposta (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodigoResposta;
		}
#pragma warning restore 0169

		public virtual unsafe short CodigoResposta {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getCodigoResposta' and count(parameter)=0]"
			[Register ("getCodigoResposta", "()S", "GetGetCodigoRespostaHandler")]
			get {
				const string __id = "getCodigoResposta.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDadosContas;
#pragma warning disable 0169
		static Delegate GetGetDadosContasHandler ()
		{
			if (cb_getDadosContas == null)
				cb_getDadosContas = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDadosContas);
			return cb_getDadosContas;
		}

		static IntPtr n_GetDadosContas (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DadosContas);
		}
#pragma warning restore 0169

		static Delegate cb_setDadosContas_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDadosContas_Ljava_lang_String_Handler ()
		{
			if (cb_setDadosContas_Ljava_lang_String_ == null)
				cb_setDadosContas_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDadosContas_Ljava_lang_String_);
			return cb_setDadosContas_Ljava_lang_String_;
		}

		static void n_SetDadosContas_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DadosContas = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DadosContas {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getDadosContas' and count(parameter)=0]"
			[Register ("getDadosContas", "()Ljava/lang/String;", "GetGetDadosContasHandler")]
			get {
				const string __id = "getDadosContas.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDadosContas' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDadosContas", "(Ljava/lang/String;)V", "GetSetDadosContas_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDadosContas.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDadosDesfazimento;
#pragma warning disable 0169
		static Delegate GetGetDadosDesfazimentoHandler ()
		{
			if (cb_getDadosDesfazimento == null)
				cb_getDadosDesfazimento = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDadosDesfazimento);
			return cb_getDadosDesfazimento;
		}

		static IntPtr n_GetDadosDesfazimento (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DadosDesfazimento);
		}
#pragma warning restore 0169

		static Delegate cb_setDadosDesfazimento_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDadosDesfazimento_Ljava_lang_String_Handler ()
		{
			if (cb_setDadosDesfazimento_Ljava_lang_String_ == null)
				cb_setDadosDesfazimento_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDadosDesfazimento_Ljava_lang_String_);
			return cb_setDadosDesfazimento_Ljava_lang_String_;
		}

		static void n_SetDadosDesfazimento_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DadosDesfazimento = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DadosDesfazimento {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getDadosDesfazimento' and count(parameter)=0]"
			[Register ("getDadosDesfazimento", "()Ljava/lang/String;", "GetGetDadosDesfazimentoHandler")]
			get {
				const string __id = "getDadosDesfazimento.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDadosDesfazimento' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDadosDesfazimento", "(Ljava/lang/String;)V", "GetSetDadosDesfazimento_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDadosDesfazimento.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDadosSaida;
#pragma warning disable 0169
		static Delegate GetGetDadosSaidaHandler ()
		{
			if (cb_getDadosSaida == null)
				cb_getDadosSaida = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDadosSaida);
			return cb_getDadosSaida;
		}

		static IntPtr n_GetDadosSaida (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DadosSaida);
		}
#pragma warning restore 0169

		public virtual unsafe string DadosSaida {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getDadosSaida' and count(parameter)=0]"
			[Register ("getDadosSaida", "()Ljava/lang/String;", "GetGetDadosSaidaHandler")]
			get {
				const string __id = "getDadosSaida.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDadosServico;
#pragma warning disable 0169
		static Delegate GetGetDadosServicoHandler ()
		{
			if (cb_getDadosServico == null)
				cb_getDadosServico = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDadosServico);
			return cb_getDadosServico;
		}

		static IntPtr n_GetDadosServico (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DadosServico);
		}
#pragma warning restore 0169

		public virtual unsafe string DadosServico {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getDadosServico' and count(parameter)=0]"
			[Register ("getDadosServico", "()Ljava/lang/String;", "GetGetDadosServicoHandler")]
			get {
				const string __id = "getDadosServico.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProximoComando;
#pragma warning disable 0169
		static Delegate GetGetProximoComandoHandler ()
		{
			if (cb_getProximoComando == null)
				cb_getProximoComando = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProximoComando);
			return cb_getProximoComando;
		}

		static int n_GetProximoComando (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProximoComando;
		}
#pragma warning restore 0169

		public virtual unsafe int ProximoComando {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getProximoComando' and count(parameter)=0]"
			[Register ("getProximoComando", "()I", "GetGetProximoComandoHandler")]
			get {
				const string __id = "getProximoComando.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSenha;
#pragma warning disable 0169
		static Delegate GetGetSenhaHandler ()
		{
			if (cb_getSenha == null)
				cb_getSenha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSenha);
			return cb_getSenha;
		}

		static IntPtr n_GetSenha (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Senha);
		}
#pragma warning restore 0169

		public virtual unsafe string Senha {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getSenha' and count(parameter)=0]"
			[Register ("getSenha", "()Ljava/lang/String;", "GetGetSenhaHandler")]
			get {
				const string __id = "getSenha.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTamanhoMaximo;
#pragma warning disable 0169
		static Delegate GetGetTamanhoMaximoHandler ()
		{
			if (cb_getTamanhoMaximo == null)
				cb_getTamanhoMaximo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetTamanhoMaximo);
			return cb_getTamanhoMaximo;
		}

		static short n_GetTamanhoMaximo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TamanhoMaximo;
		}
#pragma warning restore 0169

		static Delegate cb_setTamanhoMaximo_S;
#pragma warning disable 0169
		static Delegate GetSetTamanhoMaximo_SHandler ()
		{
			if (cb_setTamanhoMaximo_S == null)
				cb_setTamanhoMaximo_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTamanhoMaximo_S);
			return cb_setTamanhoMaximo_S;
		}

		static void n_SetTamanhoMaximo_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TamanhoMaximo = p0;
		}
#pragma warning restore 0169

		public virtual unsafe short TamanhoMaximo {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getTamanhoMaximo' and count(parameter)=0]"
			[Register ("getTamanhoMaximo", "()S", "GetGetTamanhoMaximoHandler")]
			get {
				const string __id = "getTamanhoMaximo.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamanhoMaximo' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setTamanhoMaximo", "(S)V", "GetSetTamanhoMaximo_SHandler")]
			set {
				const string __id = "setTamanhoMaximo.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTamanhoMinimo;
#pragma warning disable 0169
		static Delegate GetGetTamanhoMinimoHandler ()
		{
			if (cb_getTamanhoMinimo == null)
				cb_getTamanhoMinimo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetTamanhoMinimo);
			return cb_getTamanhoMinimo;
		}

		static short n_GetTamanhoMinimo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TamanhoMinimo;
		}
#pragma warning restore 0169

		static Delegate cb_setTamanhoMinimo_S;
#pragma warning disable 0169
		static Delegate GetSetTamanhoMinimo_SHandler ()
		{
			if (cb_setTamanhoMinimo_S == null)
				cb_setTamanhoMinimo_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTamanhoMinimo_S);
			return cb_setTamanhoMinimo_S;
		}

		static void n_SetTamanhoMinimo_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TamanhoMinimo = p0;
		}
#pragma warning restore 0169

		public virtual unsafe short TamanhoMinimo {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getTamanhoMinimo' and count(parameter)=0]"
			[Register ("getTamanhoMinimo", "()S", "GetGetTamanhoMinimoHandler")]
			get {
				const string __id = "getTamanhoMinimo.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamanhoMinimo' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setTamanhoMinimo", "(S)V", "GetSetTamanhoMinimo_SHandler")]
			set {
				const string __id = "setTamanhoMinimo.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTipoCampo;
#pragma warning disable 0169
		static Delegate GetGetTipoCampoHandler ()
		{
			if (cb_getTipoCampo == null)
				cb_getTipoCampo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTipoCampo);
			return cb_getTipoCampo;
		}

		static int n_GetTipoCampo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TipoCampo;
		}
#pragma warning restore 0169

		public virtual unsafe int TipoCampo {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getTipoCampo' and count(parameter)=0]"
			[Register ("getTipoCampo", "()I", "GetGetTipoCampoHandler")]
			get {
				const string __id = "getTipoCampo.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTipoCodigoEmBarras;
#pragma warning disable 0169
		static Delegate GetGetTipoCodigoEmBarrasHandler ()
		{
			if (cb_getTipoCodigoEmBarras == null)
				cb_getTipoCodigoEmBarras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetTipoCodigoEmBarras);
			return cb_getTipoCodigoEmBarras;
		}

		static short n_GetTipoCodigoEmBarras (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TipoCodigoEmBarras;
		}
#pragma warning restore 0169

		static Delegate cb_setTipoCodigoEmBarras_S;
#pragma warning disable 0169
		static Delegate GetSetTipoCodigoEmBarras_SHandler ()
		{
			if (cb_setTipoCodigoEmBarras_S == null)
				cb_setTipoCodigoEmBarras_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTipoCodigoEmBarras_S);
			return cb_setTipoCodigoEmBarras_S;
		}

		static void n_SetTipoCodigoEmBarras_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TipoCodigoEmBarras = p0;
		}
#pragma warning restore 0169

		public virtual unsafe short TipoCodigoEmBarras {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getTipoCodigoEmBarras' and count(parameter)=0]"
			[Register ("getTipoCodigoEmBarras", "()S", "GetGetTipoCodigoEmBarrasHandler")]
			get {
				const string __id = "getTipoCodigoEmBarras.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoCodigoEmBarras' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setTipoCodigoEmBarras", "(S)V", "GetSetTipoCodigoEmBarras_SHandler")]
			set {
				const string __id = "setTipoCodigoEmBarras.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTipoTrilha1;
#pragma warning disable 0169
		static Delegate GetGetTipoTrilha1Handler ()
		{
			if (cb_getTipoTrilha1 == null)
				cb_getTipoTrilha1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTipoTrilha1);
			return cb_getTipoTrilha1;
		}

		static IntPtr n_GetTipoTrilha1 (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TipoTrilha1);
		}
#pragma warning restore 0169

		static Delegate cb_setTipoTrilha1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTipoTrilha1_Ljava_lang_String_Handler ()
		{
			if (cb_setTipoTrilha1_Ljava_lang_String_ == null)
				cb_setTipoTrilha1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTipoTrilha1_Ljava_lang_String_);
			return cb_setTipoTrilha1_Ljava_lang_String_;
		}

		static void n_SetTipoTrilha1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TipoTrilha1 = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string TipoTrilha1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getTipoTrilha1' and count(parameter)=0]"
			[Register ("getTipoTrilha1", "()Ljava/lang/String;", "GetGetTipoTrilha1Handler")]
			get {
				const string __id = "getTipoTrilha1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoTrilha1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTipoTrilha1", "(Ljava/lang/String;)V", "GetSetTipoTrilha1_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTipoTrilha1.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTipoTrilha2;
#pragma warning disable 0169
		static Delegate GetGetTipoTrilha2Handler ()
		{
			if (cb_getTipoTrilha2 == null)
				cb_getTipoTrilha2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTipoTrilha2);
			return cb_getTipoTrilha2;
		}

		static IntPtr n_GetTipoTrilha2 (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TipoTrilha2);
		}
#pragma warning restore 0169

		static Delegate cb_setTipoTrilha2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTipoTrilha2_Ljava_lang_String_Handler ()
		{
			if (cb_setTipoTrilha2_Ljava_lang_String_ == null)
				cb_setTipoTrilha2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTipoTrilha2_Ljava_lang_String_);
			return cb_setTipoTrilha2_Ljava_lang_String_;
		}

		static void n_SetTipoTrilha2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TipoTrilha2 = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string TipoTrilha2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getTipoTrilha2' and count(parameter)=0]"
			[Register ("getTipoTrilha2", "()Ljava/lang/String;", "GetGetTipoTrilha2Handler")]
			get {
				const string __id = "getTipoTrilha2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoTrilha2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTipoTrilha2", "(Ljava/lang/String;)V", "GetSetTipoTrilha2_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTipoTrilha2.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrilha1;
#pragma warning disable 0169
		static Delegate GetGetTrilha1Handler ()
		{
			if (cb_getTrilha1 == null)
				cb_getTrilha1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrilha1);
			return cb_getTrilha1;
		}

		static IntPtr n_GetTrilha1 (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Trilha1);
		}
#pragma warning restore 0169

		static Delegate cb_setTrilha1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrilha1_Ljava_lang_String_Handler ()
		{
			if (cb_setTrilha1_Ljava_lang_String_ == null)
				cb_setTrilha1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrilha1_Ljava_lang_String_);
			return cb_setTrilha1_Ljava_lang_String_;
		}

		static void n_SetTrilha1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Trilha1 = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Trilha1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getTrilha1' and count(parameter)=0]"
			[Register ("getTrilha1", "()Ljava/lang/String;", "GetGetTrilha1Handler")]
			get {
				const string __id = "getTrilha1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTrilha1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrilha1", "(Ljava/lang/String;)V", "GetSetTrilha1_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTrilha1.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrilha2;
#pragma warning disable 0169
		static Delegate GetGetTrilha2Handler ()
		{
			if (cb_getTrilha2 == null)
				cb_getTrilha2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrilha2);
			return cb_getTrilha2;
		}

		static IntPtr n_GetTrilha2 (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Trilha2);
		}
#pragma warning restore 0169

		static Delegate cb_setTrilha2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrilha2_Ljava_lang_String_Handler ()
		{
			if (cb_setTrilha2_Ljava_lang_String_ == null)
				cb_setTrilha2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrilha2_Ljava_lang_String_);
			return cb_setTrilha2_Ljava_lang_String_;
		}

		static void n_SetTrilha2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Trilha2 = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Trilha2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getTrilha2' and count(parameter)=0]"
			[Register ("getTrilha2", "()Ljava/lang/String;", "GetGetTrilha2Handler")]
			get {
				const string __id = "getTrilha2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTrilha2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrilha2", "(Ljava/lang/String;)V", "GetSetTrilha2_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTrilha2.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrilha3;
#pragma warning disable 0169
		static Delegate GetGetTrilha3Handler ()
		{
			if (cb_getTrilha3 == null)
				cb_getTrilha3 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrilha3);
			return cb_getTrilha3;
		}

		static IntPtr n_GetTrilha3 (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Trilha3);
		}
#pragma warning restore 0169

		static Delegate cb_setTrilha3_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrilha3_Ljava_lang_String_Handler ()
		{
			if (cb_setTrilha3_Ljava_lang_String_ == null)
				cb_setTrilha3_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrilha3_Ljava_lang_String_);
			return cb_setTrilha3_Ljava_lang_String_;
		}

		static void n_SetTrilha3_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Trilha3 = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Trilha3 {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getTrilha3' and count(parameter)=0]"
			[Register ("getTrilha3", "()Ljava/lang/String;", "GetGetTrilha3Handler")]
			get {
				const string __id = "getTrilha3.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTrilha3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrilha3", "(Ljava/lang/String;)V", "GetSetTrilha3_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTrilha3.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVersaoCliSiTef;
#pragma warning disable 0169
		static Delegate GetGetVersaoCliSiTefHandler ()
		{
			if (cb_getVersaoCliSiTef == null)
				cb_getVersaoCliSiTef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersaoCliSiTef);
			return cb_getVersaoCliSiTef;
		}

		static IntPtr n_GetVersaoCliSiTef (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersaoCliSiTef);
		}
#pragma warning restore 0169

		public virtual unsafe string VersaoCliSiTef {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getVersaoCliSiTef' and count(parameter)=0]"
			[Register ("getVersaoCliSiTef", "()Ljava/lang/String;", "GetGetVersaoCliSiTefHandler")]
			get {
				const string __id = "getVersaoCliSiTef.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersaoCliSiTefI;
#pragma warning disable 0169
		static Delegate GetGetVersaoCliSiTefIHandler ()
		{
			if (cb_getVersaoCliSiTefI == null)
				cb_getVersaoCliSiTefI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersaoCliSiTefI);
			return cb_getVersaoCliSiTefI;
		}

		static IntPtr n_GetVersaoCliSiTefI (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersaoCliSiTefI);
		}
#pragma warning restore 0169

		public virtual unsafe string VersaoCliSiTefI {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getVersaoCliSiTefI' and count(parameter)=0]"
			[Register ("getVersaoCliSiTefI", "()Ljava/lang/String;", "GetGetVersaoCliSiTefIHandler")]
			get {
				const string __id = "getVersaoCliSiTefI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_LeTrilhaChipInterativo_I;
#pragma warning disable 0169
		static Delegate GetLeTrilhaChipInterativo_IHandler ()
		{
			if (cb_LeTrilhaChipInterativo_I == null)
				cb_LeTrilhaChipInterativo_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_LeTrilhaChipInterativo_I);
			return cb_LeTrilhaChipInterativo_I;
		}

		static int n_LeTrilhaChipInterativo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeTrilhaChipInterativo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='LeTrilhaChipInterativo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("LeTrilhaChipInterativo", "(I)I", "GetLeTrilhaChipInterativo_IHandler")]
		public virtual unsafe int LeTrilhaChipInterativo (int p0)
		{
			const string __id = "LeTrilhaChipInterativo.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_abrePinPad;
#pragma warning disable 0169
		static Delegate GetAbrePinPadHandler ()
		{
			if (cb_abrePinPad == null)
				cb_abrePinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_AbrePinPad);
			return cb_abrePinPad;
		}

		static int n_AbrePinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AbrePinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='abrePinPad' and count(parameter)=0]"
		[Register ("abrePinPad", "()I", "GetAbrePinPadHandler")]
		public virtual unsafe int AbrePinPad ()
		{
			const string __id = "abrePinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_carregaArquivosTraducao;
#pragma warning disable 0169
		static Delegate GetCarregaArquivosTraducaoHandler ()
		{
			if (cb_carregaArquivosTraducao == null)
				cb_carregaArquivosTraducao = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CarregaArquivosTraducao);
			return cb_carregaArquivosTraducao;
		}

		static int n_CarregaArquivosTraducao (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CarregaArquivosTraducao ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='carregaArquivosTraducao' and count(parameter)=0]"
		[Register ("carregaArquivosTraducao", "()I", "GetCarregaArquivosTraducaoHandler")]
		public virtual unsafe int CarregaArquivosTraducao ()
		{
			const string __id = "carregaArquivosTraducao.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_carregaArquivosTraducao_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCarregaArquivosTraducao_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_carregaArquivosTraducao_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_carregaArquivosTraducao_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_CarregaArquivosTraducao_Ljava_lang_String_Ljava_lang_String_);
			return cb_carregaArquivosTraducao_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_CarregaArquivosTraducao_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CarregaArquivosTraducao (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='carregaArquivosTraducao' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("carregaArquivosTraducao", "(Ljava/lang/String;Ljava/lang/String;)I", "GetCarregaArquivosTraducao_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int CarregaArquivosTraducao (string p0, string p1)
		{
			const string __id = "carregaArquivosTraducao.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_configuraIntSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetConfiguraIntSiTefInterativoHandler ()
		{
			if (cb_configuraIntSiTefInterativo == null)
				cb_configuraIntSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ConfiguraIntSiTefInterativo);
			return cb_configuraIntSiTefInterativo;
		}

		static int n_ConfiguraIntSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConfiguraIntSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='configuraIntSiTefInterativo' and count(parameter)=0]"
		[Register ("configuraIntSiTefInterativo", "()I", "GetConfiguraIntSiTefInterativoHandler")]
		public virtual unsafe int ConfiguraIntSiTefInterativo ()
		{
			const string __id = "configuraIntSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_configuraIntSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConfiguraIntSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_configuraIntSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_configuraIntSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ConfiguraIntSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_configuraIntSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ConfiguraIntSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConfiguraIntSiTefInterativo (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='configuraIntSiTefInterativo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("configuraIntSiTefInterativo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetConfiguraIntSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ConfiguraIntSiTefInterativo (string p0, string p1, string p2)
		{
			const string __id = "configuraIntSiTefInterativo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_configuraIntSiTefInterativoEx;
#pragma warning disable 0169
		static Delegate GetConfiguraIntSiTefInterativoExHandler ()
		{
			if (cb_configuraIntSiTefInterativoEx == null)
				cb_configuraIntSiTefInterativoEx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ConfiguraIntSiTefInterativoEx);
			return cb_configuraIntSiTefInterativoEx;
		}

		static int n_ConfiguraIntSiTefInterativoEx (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConfiguraIntSiTefInterativoEx ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='configuraIntSiTefInterativoEx' and count(parameter)=0]"
		[Register ("configuraIntSiTefInterativoEx", "()I", "GetConfiguraIntSiTefInterativoExHandler")]
		public virtual unsafe int ConfiguraIntSiTefInterativoEx ()
		{
			const string __id = "configuraIntSiTefInterativoEx.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_configuraIntSiTefInterativoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConfiguraIntSiTefInterativoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_configuraIntSiTefInterativoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_configuraIntSiTefInterativoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ConfiguraIntSiTefInterativoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_configuraIntSiTefInterativoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ConfiguraIntSiTefInterativoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConfiguraIntSiTefInterativoEx (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='configuraIntSiTefInterativoEx' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("configuraIntSiTefInterativoEx", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetConfiguraIntSiTefInterativoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ConfiguraIntSiTefInterativoEx (string p0, string p1, string p2, string p3)
		{
			const string __id = "configuraIntSiTefInterativoEx.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_consultaDescontoSocioTorcedor;
#pragma warning disable 0169
		static Delegate GetConsultaDescontoSocioTorcedorHandler ()
		{
			if (cb_consultaDescontoSocioTorcedor == null)
				cb_consultaDescontoSocioTorcedor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ConsultaDescontoSocioTorcedor);
			return cb_consultaDescontoSocioTorcedor;
		}

		static int n_ConsultaDescontoSocioTorcedor (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConsultaDescontoSocioTorcedor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='consultaDescontoSocioTorcedor' and count(parameter)=0]"
		[Register ("consultaDescontoSocioTorcedor", "()I", "GetConsultaDescontoSocioTorcedorHandler")]
		public virtual unsafe int ConsultaDescontoSocioTorcedor ()
		{
			const string __id = "consultaDescontoSocioTorcedor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_consultaDescontoSocioTorcedor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConsultaDescontoSocioTorcedor_Ljava_lang_String_Handler ()
		{
			if (cb_consultaDescontoSocioTorcedor_Ljava_lang_String_ == null)
				cb_consultaDescontoSocioTorcedor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ConsultaDescontoSocioTorcedor_Ljava_lang_String_);
			return cb_consultaDescontoSocioTorcedor_Ljava_lang_String_;
		}

		static int n_ConsultaDescontoSocioTorcedor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConsultaDescontoSocioTorcedor (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='consultaDescontoSocioTorcedor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("consultaDescontoSocioTorcedor", "(Ljava/lang/String;)I", "GetConsultaDescontoSocioTorcedor_Ljava_lang_String_Handler")]
		public virtual unsafe int ConsultaDescontoSocioTorcedor (string p0)
		{
			const string __id = "consultaDescontoSocioTorcedor.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_consultaParametrosSiTef;
#pragma warning disable 0169
		static Delegate GetConsultaParametrosSiTefHandler ()
		{
			if (cb_consultaParametrosSiTef == null)
				cb_consultaParametrosSiTef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ConsultaParametrosSiTef);
			return cb_consultaParametrosSiTef;
		}

		static int n_ConsultaParametrosSiTef (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConsultaParametrosSiTef ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='consultaParametrosSiTef' and count(parameter)=0]"
		[Register ("consultaParametrosSiTef", "()I", "GetConsultaParametrosSiTefHandler")]
		public virtual unsafe int ConsultaParametrosSiTef ()
		{
			const string __id = "consultaParametrosSiTef.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_consultaParametrosSiTef_I;
#pragma warning disable 0169
		static Delegate GetConsultaParametrosSiTef_IHandler ()
		{
			if (cb_consultaParametrosSiTef_I == null)
				cb_consultaParametrosSiTef_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ConsultaParametrosSiTef_I);
			return cb_consultaParametrosSiTef_I;
		}

		static int n_ConsultaParametrosSiTef_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConsultaParametrosSiTef (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='consultaParametrosSiTef' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("consultaParametrosSiTef", "(I)I", "GetConsultaParametrosSiTef_IHandler")]
		public virtual unsafe int ConsultaParametrosSiTef (int p0)
		{
			const string __id = "consultaParametrosSiTef.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_consultaQtdeDescontoSocioTorcedor;
#pragma warning disable 0169
		static Delegate GetConsultaQtdeDescontoSocioTorcedorHandler ()
		{
			if (cb_consultaQtdeDescontoSocioTorcedor == null)
				cb_consultaQtdeDescontoSocioTorcedor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ConsultaQtdeDescontoSocioTorcedor);
			return cb_consultaQtdeDescontoSocioTorcedor;
		}

		static int n_ConsultaQtdeDescontoSocioTorcedor (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConsultaQtdeDescontoSocioTorcedor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='consultaQtdeDescontoSocioTorcedor' and count(parameter)=0]"
		[Register ("consultaQtdeDescontoSocioTorcedor", "()I", "GetConsultaQtdeDescontoSocioTorcedorHandler")]
		public virtual unsafe int ConsultaQtdeDescontoSocioTorcedor ()
		{
			const string __id = "consultaQtdeDescontoSocioTorcedor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_consultaQtdeDescontoSocioTorcedor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConsultaQtdeDescontoSocioTorcedor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_consultaQtdeDescontoSocioTorcedor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_consultaQtdeDescontoSocioTorcedor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_ConsultaQtdeDescontoSocioTorcedor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_);
			return cb_consultaQtdeDescontoSocioTorcedor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		}

		static int n_ConsultaQtdeDescontoSocioTorcedor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConsultaQtdeDescontoSocioTorcedor (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='consultaQtdeDescontoSocioTorcedor' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("consultaQtdeDescontoSocioTorcedor", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)I", "GetConsultaQtdeDescontoSocioTorcedor_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ConsultaQtdeDescontoSocioTorcedor (string p0, int p1, string p2, string p3)
		{
			const string __id = "consultaQtdeDescontoSocioTorcedor.(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_continuaFuncaoSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetContinuaFuncaoSiTefInterativoHandler ()
		{
			if (cb_continuaFuncaoSiTefInterativo == null)
				cb_continuaFuncaoSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ContinuaFuncaoSiTefInterativo);
			return cb_continuaFuncaoSiTefInterativo;
		}

		static int n_ContinuaFuncaoSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContinuaFuncaoSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='continuaFuncaoSiTefInterativo' and count(parameter)=0]"
		[Register ("continuaFuncaoSiTefInterativo", "()I", "GetContinuaFuncaoSiTefInterativoHandler")]
		public virtual unsafe int ContinuaFuncaoSiTefInterativo ()
		{
			const string __id = "continuaFuncaoSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_correspondenteBancarioSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetCorrespondenteBancarioSiTefInterativoHandler ()
		{
			if (cb_correspondenteBancarioSiTefInterativo == null)
				cb_correspondenteBancarioSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CorrespondenteBancarioSiTefInterativo);
			return cb_correspondenteBancarioSiTefInterativo;
		}

		static int n_CorrespondenteBancarioSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CorrespondenteBancarioSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='correspondenteBancarioSiTefInterativo' and count(parameter)=0]"
		[Register ("correspondenteBancarioSiTefInterativo", "()I", "GetCorrespondenteBancarioSiTefInterativoHandler")]
		public virtual unsafe int CorrespondenteBancarioSiTefInterativo ()
		{
			const string __id = "correspondenteBancarioSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_correspondenteBancarioSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCorrespondenteBancarioSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_correspondenteBancarioSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_correspondenteBancarioSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_CorrespondenteBancarioSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_correspondenteBancarioSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_CorrespondenteBancarioSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CorrespondenteBancarioSiTefInterativo (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='correspondenteBancarioSiTefInterativo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("correspondenteBancarioSiTefInterativo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetCorrespondenteBancarioSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int CorrespondenteBancarioSiTefInterativo (string p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "correspondenteBancarioSiTefInterativo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_descarregaMensagens;
#pragma warning disable 0169
		static Delegate GetDescarregaMensagensHandler ()
		{
			if (cb_descarregaMensagens == null)
				cb_descarregaMensagens = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescarregaMensagens);
			return cb_descarregaMensagens;
		}

		static int n_DescarregaMensagens (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescarregaMensagens ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='descarregaMensagens' and count(parameter)=0]"
		[Register ("descarregaMensagens", "()I", "GetDescarregaMensagensHandler")]
		public virtual unsafe int DescarregaMensagens ()
		{
			const string __id = "descarregaMensagens.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_desfazTransacaoSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetDesfazTransacaoSiTefInterativoHandler ()
		{
			if (cb_desfazTransacaoSiTefInterativo == null)
				cb_desfazTransacaoSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DesfazTransacaoSiTefInterativo);
			return cb_desfazTransacaoSiTefInterativo;
		}

		static int n_DesfazTransacaoSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DesfazTransacaoSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='desfazTransacaoSiTefInterativo' and count(parameter)=0]"
		[Register ("desfazTransacaoSiTefInterativo", "()I", "GetDesfazTransacaoSiTefInterativoHandler")]
		public virtual unsafe int DesfazTransacaoSiTefInterativo ()
		{
			const string __id = "desfazTransacaoSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_desfazTransacaoSiTefInterativo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDesfazTransacaoSiTefInterativo_Ljava_lang_String_Handler ()
		{
			if (cb_desfazTransacaoSiTefInterativo_Ljava_lang_String_ == null)
				cb_desfazTransacaoSiTefInterativo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DesfazTransacaoSiTefInterativo_Ljava_lang_String_);
			return cb_desfazTransacaoSiTefInterativo_Ljava_lang_String_;
		}

		static int n_DesfazTransacaoSiTefInterativo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DesfazTransacaoSiTefInterativo (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='desfazTransacaoSiTefInterativo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("desfazTransacaoSiTefInterativo", "(Ljava/lang/String;)I", "GetDesfazTransacaoSiTefInterativo_Ljava_lang_String_Handler")]
		public virtual unsafe int DesfazTransacaoSiTefInterativo (string p0)
		{
			const string __id = "desfazTransacaoSiTefInterativo.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_efetuaPagamentoSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetEfetuaPagamentoSiTefInterativoHandler ()
		{
			if (cb_efetuaPagamentoSiTefInterativo == null)
				cb_efetuaPagamentoSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_EfetuaPagamentoSiTefInterativo);
			return cb_efetuaPagamentoSiTefInterativo;
		}

		static int n_EfetuaPagamentoSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EfetuaPagamentoSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='efetuaPagamentoSiTefInterativo' and count(parameter)=0]"
		[Register ("efetuaPagamentoSiTefInterativo", "()I", "GetEfetuaPagamentoSiTefInterativoHandler")]
		public virtual unsafe int EfetuaPagamentoSiTefInterativo ()
		{
			const string __id = "efetuaPagamentoSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_efetuaPagamentoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEfetuaPagamentoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_efetuaPagamentoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_efetuaPagamentoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_EfetuaPagamentoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_efetuaPagamentoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_EfetuaPagamentoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EfetuaPagamentoSiTefInterativo (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='efetuaPagamentoSiTefInterativo' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("efetuaPagamentoSiTefInterativo", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetEfetuaPagamentoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int EfetuaPagamentoSiTefInterativo (int p0, string p1, string p2, string p3, string p4, string p5, string p6)
		{
			const string __id = "efetuaPagamentoSiTefInterativo.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_enviaRecebeSiTefDireto;
#pragma warning disable 0169
		static Delegate GetEnviaRecebeSiTefDiretoHandler ()
		{
			if (cb_enviaRecebeSiTefDireto == null)
				cb_enviaRecebeSiTefDireto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_EnviaRecebeSiTefDireto);
			return cb_enviaRecebeSiTefDireto;
		}

		static int n_EnviaRecebeSiTefDireto (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnviaRecebeSiTefDireto ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='enviaRecebeSiTefDireto' and count(parameter)=0]"
		[Register ("enviaRecebeSiTefDireto", "()I", "GetEnviaRecebeSiTefDiretoHandler")]
		public virtual unsafe int EnviaRecebeSiTefDireto ()
		{
			const string __id = "enviaRecebeSiTefDireto.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_enviaRecebeSiTefDireto_SSSarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetEnviaRecebeSiTefDireto_SSSarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SHandler ()
		{
			if (cb_enviaRecebeSiTefDireto_SSSarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S == null)
				cb_enviaRecebeSiTefDireto_SSSarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, short, short, IntPtr, short, short, short, IntPtr, IntPtr, IntPtr, IntPtr, short, int>) n_EnviaRecebeSiTefDireto_SSSarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S);
			return cb_enviaRecebeSiTefDireto_SSSarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S;
		}

		static int n_EnviaRecebeSiTefDireto_SSSarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, short p0, short p1, short p2, IntPtr native_p3, short p4, short p5, short p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10, short p11)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			string p8 = JNIEnv.GetString (native_p8, JniHandleOwnership.DoNotTransfer);
			string p9 = JNIEnv.GetString (native_p9, JniHandleOwnership.DoNotTransfer);
			string p10 = JNIEnv.GetString (native_p10, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EnviaRecebeSiTefDireto (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='enviaRecebeSiTefDireto' and count(parameter)=12 and parameter[1][@type='short'] and parameter[2][@type='short'] and parameter[3][@type='short'] and parameter[4][@type='byte[]'] and parameter[5][@type='short'] and parameter[6][@type='short'] and parameter[7][@type='short'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String'] and parameter[12][@type='short']]"
		[Register ("enviaRecebeSiTefDireto", "(SSS[BSSSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;S)I", "GetEnviaRecebeSiTefDireto_SSSarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SHandler")]
		public virtual unsafe int EnviaRecebeSiTefDireto (short p0, short p1, short p2, byte[] p3, short p4, short p5, short p6, string p7, string p8, string p9, string p10, short p11)
		{
			const string __id = "enviaRecebeSiTefDireto.(SSS[BSSSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;S)I";
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			IntPtr native_p10 = JNIEnv.NewString (p10);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (native_p7);
				__args [8] = new JniArgumentValue (native_p8);
				__args [9] = new JniArgumentValue (native_p9);
				__args [10] = new JniArgumentValue (native_p10);
				__args [11] = new JniArgumentValue (p11);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
				JNIEnv.DeleteLocalRef (native_p10);
			}
		}

		static Delegate cb_enviaRecebeSitServicos;
#pragma warning disable 0169
		static Delegate GetEnviaRecebeSitServicosHandler ()
		{
			if (cb_enviaRecebeSitServicos == null)
				cb_enviaRecebeSitServicos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_EnviaRecebeSitServicos);
			return cb_enviaRecebeSitServicos;
		}

		static int n_EnviaRecebeSitServicos (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnviaRecebeSitServicos ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='enviaRecebeSitServicos' and count(parameter)=0]"
		[Register ("enviaRecebeSitServicos", "()I", "GetEnviaRecebeSitServicosHandler")]
		public virtual unsafe int EnviaRecebeSitServicos ()
		{
			const string __id = "enviaRecebeSitServicos.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_enviaRecebeSitServicos_SarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnviaRecebeSitServicos_SarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_enviaRecebeSitServicos_SarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_enviaRecebeSitServicos_SarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr, short, short, short, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_EnviaRecebeSitServicos_SarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_enviaRecebeSitServicos_SarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_EnviaRecebeSitServicos_SarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, short p0, IntPtr native_p1, short p2, short p3, short p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			string p8 = JNIEnv.GetString (native_p8, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EnviaRecebeSitServicos (p0, p1, p2, p3, p4, p5, p6, p7, p8);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='enviaRecebeSitServicos' and count(parameter)=9 and parameter[1][@type='short'] and parameter[2][@type='byte[]'] and parameter[3][@type='short'] and parameter[4][@type='short'] and parameter[5][@type='short'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String']]"
		[Register ("enviaRecebeSitServicos", "(S[BSSSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetEnviaRecebeSitServicos_SarrayBSSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int EnviaRecebeSitServicos (short p0, byte[] p1, short p2, short p3, short p4, string p5, string p6, string p7, string p8)
		{
			const string __id = "enviaRecebeSitServicos.(S[BSSSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (native_p7);
				__args [8] = new JniArgumentValue (native_p8);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p8);
			}
		}

		static Delegate cb_escreveMensagemPermanentePinPad;
#pragma warning disable 0169
		static Delegate GetEscreveMensagemPermanentePinPadHandler ()
		{
			if (cb_escreveMensagemPermanentePinPad == null)
				cb_escreveMensagemPermanentePinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_EscreveMensagemPermanentePinPad);
			return cb_escreveMensagemPermanentePinPad;
		}

		static int n_EscreveMensagemPermanentePinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EscreveMensagemPermanentePinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='escreveMensagemPermanentePinPad' and count(parameter)=0]"
		[Register ("escreveMensagemPermanentePinPad", "()I", "GetEscreveMensagemPermanentePinPadHandler")]
		public virtual unsafe int EscreveMensagemPermanentePinPad ()
		{
			const string __id = "escreveMensagemPermanentePinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_escreveMensagemPermanentePinPad_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreveMensagemPermanentePinPad_Ljava_lang_String_Handler ()
		{
			if (cb_escreveMensagemPermanentePinPad_Ljava_lang_String_ == null)
				cb_escreveMensagemPermanentePinPad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_EscreveMensagemPermanentePinPad_Ljava_lang_String_);
			return cb_escreveMensagemPermanentePinPad_Ljava_lang_String_;
		}

		static int n_EscreveMensagemPermanentePinPad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EscreveMensagemPermanentePinPad (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='escreveMensagemPermanentePinPad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escreveMensagemPermanentePinPad", "(Ljava/lang/String;)I", "GetEscreveMensagemPermanentePinPad_Ljava_lang_String_Handler")]
		public virtual unsafe int EscreveMensagemPermanentePinPad (string p0)
		{
			const string __id = "escreveMensagemPermanentePinPad.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_escreveMensagemPinPad;
#pragma warning disable 0169
		static Delegate GetEscreveMensagemPinPadHandler ()
		{
			if (cb_escreveMensagemPinPad == null)
				cb_escreveMensagemPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_EscreveMensagemPinPad);
			return cb_escreveMensagemPinPad;
		}

		static int n_EscreveMensagemPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EscreveMensagemPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='escreveMensagemPinPad' and count(parameter)=0]"
		[Register ("escreveMensagemPinPad", "()I", "GetEscreveMensagemPinPadHandler")]
		public virtual unsafe int EscreveMensagemPinPad ()
		{
			const string __id = "escreveMensagemPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_escreveMensagemPinPad_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreveMensagemPinPad_Ljava_lang_String_Handler ()
		{
			if (cb_escreveMensagemPinPad_Ljava_lang_String_ == null)
				cb_escreveMensagemPinPad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_EscreveMensagemPinPad_Ljava_lang_String_);
			return cb_escreveMensagemPinPad_Ljava_lang_String_;
		}

		static int n_EscreveMensagemPinPad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EscreveMensagemPinPad (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='escreveMensagemPinPad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escreveMensagemPinPad", "(Ljava/lang/String;)I", "GetEscreveMensagemPinPad_Ljava_lang_String_Handler")]
		public virtual unsafe int EscreveMensagemPinPad (string p0)
		{
			const string __id = "escreveMensagemPinPad.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_executaEnviaRecebeSiTefDireto;
#pragma warning disable 0169
		static Delegate GetExecutaEnviaRecebeSiTefDiretoHandler ()
		{
			if (cb_executaEnviaRecebeSiTefDireto == null)
				cb_executaEnviaRecebeSiTefDireto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ExecutaEnviaRecebeSiTefDireto);
			return cb_executaEnviaRecebeSiTefDireto;
		}

		static int n_ExecutaEnviaRecebeSiTefDireto (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExecutaEnviaRecebeSiTefDireto ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='executaEnviaRecebeSiTefDireto' and count(parameter)=0]"
		[Register ("executaEnviaRecebeSiTefDireto", "()I", "GetExecutaEnviaRecebeSiTefDiretoHandler")]
		public virtual unsafe int ExecutaEnviaRecebeSiTefDireto ()
		{
			const string __id = "executaEnviaRecebeSiTefDireto.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_executaEnviaRecebeSiTefDireto_SSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetExecutaEnviaRecebeSiTefDireto_SSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SHandler ()
		{
			if (cb_executaEnviaRecebeSiTefDireto_SSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S == null)
				cb_executaEnviaRecebeSiTefDireto_SSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, short, short, IntPtr, IntPtr, IntPtr, IntPtr, short, int>) n_ExecutaEnviaRecebeSiTefDireto_SSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S);
			return cb_executaEnviaRecebeSiTefDireto_SSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S;
		}

		static int n_ExecutaEnviaRecebeSiTefDireto_SSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, short p0, short p1, short p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, short p7)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ExecutaEnviaRecebeSiTefDireto (p0, p1, p2, p3, p4, p5, p6, p7);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='executaEnviaRecebeSiTefDireto' and count(parameter)=8 and parameter[1][@type='short'] and parameter[2][@type='short'] and parameter[3][@type='short'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='short']]"
		[Register ("executaEnviaRecebeSiTefDireto", "(SSSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;S)I", "GetExecutaEnviaRecebeSiTefDireto_SSSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_SHandler")]
		public virtual unsafe int ExecutaEnviaRecebeSiTefDireto (short p0, short p1, short p2, string p3, string p4, string p5, string p6, short p7)
		{
			const string __id = "executaEnviaRecebeSiTefDireto.(SSSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;S)I";
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (p7);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_fechaPinPad;
#pragma warning disable 0169
		static Delegate GetFechaPinPadHandler ()
		{
			if (cb_fechaPinPad == null)
				cb_fechaPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FechaPinPad);
			return cb_fechaPinPad;
		}

		static int n_FechaPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FechaPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='fechaPinPad' and count(parameter)=0]"
		[Register ("fechaPinPad", "()I", "GetFechaPinPadHandler")]
		public virtual unsafe int FechaPinPad ()
		{
			const string __id = "fechaPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finalizaFuncaoSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetFinalizaFuncaoSiTefInterativoHandler ()
		{
			if (cb_finalizaFuncaoSiTefInterativo == null)
				cb_finalizaFuncaoSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FinalizaFuncaoSiTefInterativo);
			return cb_finalizaFuncaoSiTefInterativo;
		}

		static int n_FinalizaFuncaoSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalizaFuncaoSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaFuncaoSiTefInterativo' and count(parameter)=0]"
		[Register ("finalizaFuncaoSiTefInterativo", "()I", "GetFinalizaFuncaoSiTefInterativoHandler")]
		public virtual unsafe int FinalizaFuncaoSiTefInterativo ()
		{
			const string __id = "finalizaFuncaoSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finalizaFuncaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinalizaFuncaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finalizaFuncaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finalizaFuncaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_FinalizaFuncaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finalizaFuncaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_FinalizaFuncaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, short p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FinalizaFuncaoSiTefInterativo (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaFuncaoSiTefInterativo' and count(parameter)=5 and parameter[1][@type='short'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("finalizaFuncaoSiTefInterativo", "(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetFinalizaFuncaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int FinalizaFuncaoSiTefInterativo (short p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "finalizaFuncaoSiTefInterativo.(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_finalizaTransacaoIdentificadaSiTef;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoIdentificadaSiTefHandler ()
		{
			if (cb_finalizaTransacaoIdentificadaSiTef == null)
				cb_finalizaTransacaoIdentificadaSiTef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FinalizaTransacaoIdentificadaSiTef);
			return cb_finalizaTransacaoIdentificadaSiTef;
		}

		static int n_FinalizaTransacaoIdentificadaSiTef (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalizaTransacaoIdentificadaSiTef ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoIdentificadaSiTef' and count(parameter)=0]"
		[Register ("finalizaTransacaoIdentificadaSiTef", "()I", "GetFinalizaTransacaoIdentificadaSiTefHandler")]
		public virtual unsafe int FinalizaTransacaoIdentificadaSiTef ()
		{
			const string __id = "finalizaTransacaoIdentificadaSiTef.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finalizaTransacaoIdentificadaSiTef_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoIdentificadaSiTef_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finalizaTransacaoIdentificadaSiTef_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finalizaTransacaoIdentificadaSiTef_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, short, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_FinalizaTransacaoIdentificadaSiTef_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finalizaTransacaoIdentificadaSiTef_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_FinalizaTransacaoIdentificadaSiTef_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, short p0, short p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FinalizaTransacaoIdentificadaSiTef (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoIdentificadaSiTef' and count(parameter)=6 and parameter[1][@type='short'] and parameter[2][@type='short'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("finalizaTransacaoIdentificadaSiTef", "(SSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetFinalizaTransacaoIdentificadaSiTef_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int FinalizaTransacaoIdentificadaSiTef (short p0, short p1, string p2, string p3, string p4, string p5)
		{
			const string __id = "finalizaTransacaoIdentificadaSiTef.(SSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_finalizaTransacaoIdentificadaSiTefBonus;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoIdentificadaSiTefBonusHandler ()
		{
			if (cb_finalizaTransacaoIdentificadaSiTefBonus == null)
				cb_finalizaTransacaoIdentificadaSiTefBonus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FinalizaTransacaoIdentificadaSiTefBonus);
			return cb_finalizaTransacaoIdentificadaSiTefBonus;
		}

		static int n_FinalizaTransacaoIdentificadaSiTefBonus (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalizaTransacaoIdentificadaSiTefBonus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoIdentificadaSiTefBonus' and count(parameter)=0]"
		[Register ("finalizaTransacaoIdentificadaSiTefBonus", "()I", "GetFinalizaTransacaoIdentificadaSiTefBonusHandler")]
		public virtual unsafe int FinalizaTransacaoIdentificadaSiTefBonus ()
		{
			const string __id = "finalizaTransacaoIdentificadaSiTefBonus.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finalizaTransacaoIdentificadaSiTefBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoIdentificadaSiTefBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finalizaTransacaoIdentificadaSiTefBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finalizaTransacaoIdentificadaSiTefBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_FinalizaTransacaoIdentificadaSiTefBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finalizaTransacaoIdentificadaSiTefBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_FinalizaTransacaoIdentificadaSiTefBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, short p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FinalizaTransacaoIdentificadaSiTefBonus (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoIdentificadaSiTefBonus' and count(parameter)=7 and parameter[1][@type='short'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("finalizaTransacaoIdentificadaSiTefBonus", "(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetFinalizaTransacaoIdentificadaSiTefBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int FinalizaTransacaoIdentificadaSiTefBonus (short p0, string p1, string p2, string p3, string p4, string p5, string p6)
		{
			const string __id = "finalizaTransacaoIdentificadaSiTefBonus.(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_finalizaTransacaoSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoSiTefInterativoHandler ()
		{
			if (cb_finalizaTransacaoSiTefInterativo == null)
				cb_finalizaTransacaoSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FinalizaTransacaoSiTefInterativo);
			return cb_finalizaTransacaoSiTefInterativo;
		}

		static int n_FinalizaTransacaoSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalizaTransacaoSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoSiTefInterativo' and count(parameter)=0]"
		[Register ("finalizaTransacaoSiTefInterativo", "()I", "GetFinalizaTransacaoSiTefInterativoHandler")]
		public virtual unsafe int FinalizaTransacaoSiTefInterativo ()
		{
			const string __id = "finalizaTransacaoSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finalizaTransacaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finalizaTransacaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finalizaTransacaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr, IntPtr, IntPtr, int>) n_FinalizaTransacaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finalizaTransacaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_FinalizaTransacaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, short p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FinalizaTransacaoSiTefInterativo (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoSiTefInterativo' and count(parameter)=4 and parameter[1][@type='short'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("finalizaTransacaoSiTefInterativo", "(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetFinalizaTransacaoSiTefInterativo_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int FinalizaTransacaoSiTefInterativo (short p0, string p1, string p2, string p3)
		{
			const string __id = "finalizaTransacaoSiTefInterativo.(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_finalizaTransacaoSiTefInterativoBonus;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoSiTefInterativoBonusHandler ()
		{
			if (cb_finalizaTransacaoSiTefInterativoBonus == null)
				cb_finalizaTransacaoSiTefInterativoBonus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FinalizaTransacaoSiTefInterativoBonus);
			return cb_finalizaTransacaoSiTefInterativoBonus;
		}

		static int n_FinalizaTransacaoSiTefInterativoBonus (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalizaTransacaoSiTefInterativoBonus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoSiTefInterativoBonus' and count(parameter)=0]"
		[Register ("finalizaTransacaoSiTefInterativoBonus", "()I", "GetFinalizaTransacaoSiTefInterativoBonusHandler")]
		public virtual unsafe int FinalizaTransacaoSiTefInterativoBonus ()
		{
			const string __id = "finalizaTransacaoSiTefInterativoBonus.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finalizaTransacaoSiTefInterativoBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoSiTefInterativoBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finalizaTransacaoSiTefInterativoBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finalizaTransacaoSiTefInterativoBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_FinalizaTransacaoSiTefInterativoBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finalizaTransacaoSiTefInterativoBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_FinalizaTransacaoSiTefInterativoBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, short p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FinalizaTransacaoSiTefInterativoBonus (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoSiTefInterativoBonus' and count(parameter)=6 and parameter[1][@type='short'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("finalizaTransacaoSiTefInterativoBonus", "(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetFinalizaTransacaoSiTefInterativoBonus_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int FinalizaTransacaoSiTefInterativoBonus (short p0, string p1, string p2, string p3, string p4, string p5)
		{
			const string __id = "finalizaTransacaoSiTefInterativoBonus.(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_finalizaTransacaoSiTefInterativoEx;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoSiTefInterativoExHandler ()
		{
			if (cb_finalizaTransacaoSiTefInterativoEx == null)
				cb_finalizaTransacaoSiTefInterativoEx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FinalizaTransacaoSiTefInterativoEx);
			return cb_finalizaTransacaoSiTefInterativoEx;
		}

		static int n_FinalizaTransacaoSiTefInterativoEx (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalizaTransacaoSiTefInterativoEx ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoSiTefInterativoEx' and count(parameter)=0]"
		[Register ("finalizaTransacaoSiTefInterativoEx", "()I", "GetFinalizaTransacaoSiTefInterativoExHandler")]
		public virtual unsafe int FinalizaTransacaoSiTefInterativoEx ()
		{
			const string __id = "finalizaTransacaoSiTefInterativoEx.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finalizaTransacaoSiTefInterativoEx_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoSiTefInterativoEx_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finalizaTransacaoSiTefInterativoEx_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finalizaTransacaoSiTefInterativoEx_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_FinalizaTransacaoSiTefInterativoEx_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finalizaTransacaoSiTefInterativoEx_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_FinalizaTransacaoSiTefInterativoEx_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, short p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FinalizaTransacaoSiTefInterativoEx (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='finalizaTransacaoSiTefInterativoEx' and count(parameter)=5 and parameter[1][@type='short'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("finalizaTransacaoSiTefInterativoEx", "(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetFinalizaTransacaoSiTefInterativoEx_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int FinalizaTransacaoSiTefInterativoEx (short p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "finalizaTransacaoSiTefInterativoEx.(SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_flashVendasSitef;
#pragma warning disable 0169
		static Delegate GetFlashVendasSitefHandler ()
		{
			if (cb_flashVendasSitef == null)
				cb_flashVendasSitef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FlashVendasSitef);
			return cb_flashVendasSitef;
		}

		static int n_FlashVendasSitef (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FlashVendasSitef ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='flashVendasSitef' and count(parameter)=0]"
		[Register ("flashVendasSitef", "()I", "GetFlashVendasSitefHandler")]
		public virtual unsafe int FlashVendasSitef ()
		{
			const string __id = "flashVendasSitef.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_flashVendasSitef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFlashVendasSitef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_flashVendasSitef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_flashVendasSitef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_FlashVendasSitef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_flashVendasSitef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_FlashVendasSitef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FlashVendasSitef (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='flashVendasSitef' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("flashVendasSitef", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetFlashVendasSitef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int FlashVendasSitef (string p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "flashVendasSitef.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_forneceParametroEnviaRecebeSiTefDireto;
#pragma warning disable 0169
		static Delegate GetForneceParametroEnviaRecebeSiTefDiretoHandler ()
		{
			if (cb_forneceParametroEnviaRecebeSiTefDireto == null)
				cb_forneceParametroEnviaRecebeSiTefDireto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ForneceParametroEnviaRecebeSiTefDireto);
			return cb_forneceParametroEnviaRecebeSiTefDireto;
		}

		static int n_ForneceParametroEnviaRecebeSiTefDireto (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForneceParametroEnviaRecebeSiTefDireto ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='forneceParametroEnviaRecebeSiTefDireto' and count(parameter)=0]"
		[Register ("forneceParametroEnviaRecebeSiTefDireto", "()I", "GetForneceParametroEnviaRecebeSiTefDiretoHandler")]
		public virtual unsafe int ForneceParametroEnviaRecebeSiTefDireto ()
		{
			const string __id = "forneceParametroEnviaRecebeSiTefDireto.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_forneceParametroEnviaRecebeSiTefDireto_SLjava_lang_String_SS;
#pragma warning disable 0169
		static Delegate GetForneceParametroEnviaRecebeSiTefDireto_SLjava_lang_String_SSHandler ()
		{
			if (cb_forneceParametroEnviaRecebeSiTefDireto_SLjava_lang_String_SS == null)
				cb_forneceParametroEnviaRecebeSiTefDireto_SLjava_lang_String_SS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr, short, short, int>) n_ForneceParametroEnviaRecebeSiTefDireto_SLjava_lang_String_SS);
			return cb_forneceParametroEnviaRecebeSiTefDireto_SLjava_lang_String_SS;
		}

		static int n_ForneceParametroEnviaRecebeSiTefDireto_SLjava_lang_String_SS (IntPtr jnienv, IntPtr native__this, short p0, IntPtr native_p1, short p2, short p3)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ForneceParametroEnviaRecebeSiTefDireto (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='forneceParametroEnviaRecebeSiTefDireto' and count(parameter)=4 and parameter[1][@type='short'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short'] and parameter[4][@type='short']]"
		[Register ("forneceParametroEnviaRecebeSiTefDireto", "(SLjava/lang/String;SS)I", "GetForneceParametroEnviaRecebeSiTefDireto_SLjava_lang_String_SSHandler")]
		public virtual unsafe int ForneceParametroEnviaRecebeSiTefDireto (short p0, string p1, short p2, short p3)
		{
			const string __id = "forneceParametroEnviaRecebeSiTefDireto.(SLjava/lang/String;SS)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_funcoesGerenciaisSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetFuncoesGerenciaisSiTefInterativoHandler ()
		{
			if (cb_funcoesGerenciaisSiTefInterativo == null)
				cb_funcoesGerenciaisSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FuncoesGerenciaisSiTefInterativo);
			return cb_funcoesGerenciaisSiTefInterativo;
		}

		static int n_FuncoesGerenciaisSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FuncoesGerenciaisSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='funcoesGerenciaisSiTefInterativo' and count(parameter)=0]"
		[Register ("funcoesGerenciaisSiTefInterativo", "()I", "GetFuncoesGerenciaisSiTefInterativoHandler")]
		public virtual unsafe int FuncoesGerenciaisSiTefInterativo ()
		{
			const string __id = "funcoesGerenciaisSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_funcoesGerenciaisSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFuncoesGerenciaisSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_funcoesGerenciaisSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_funcoesGerenciaisSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_FuncoesGerenciaisSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_funcoesGerenciaisSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_FuncoesGerenciaisSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FuncoesGerenciaisSiTefInterativo (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='funcoesGerenciaisSiTefInterativo' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("funcoesGerenciaisSiTefInterativo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetFuncoesGerenciaisSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int FuncoesGerenciaisSiTefInterativo (string p0, string p1, string p2, string p3)
		{
			const string __id = "funcoesGerenciaisSiTefInterativo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getDadosRx;
#pragma warning disable 0169
		static Delegate GetGetDadosRxHandler ()
		{
			if (cb_getDadosRx == null)
				cb_getDadosRx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDadosRx);
			return cb_getDadosRx;
		}

		static IntPtr n_GetDadosRx (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDadosRx ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='getDadosRx' and count(parameter)=0]"
		[Register ("getDadosRx", "()[B", "GetGetDadosRxHandler")]
		public virtual unsafe byte[] GetDadosRx ()
		{
			const string __id = "getDadosRx.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_gravaDadosCriptografados;
#pragma warning disable 0169
		static Delegate GetGravaDadosCriptografadosHandler ()
		{
			if (cb_gravaDadosCriptografados == null)
				cb_gravaDadosCriptografados = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GravaDadosCriptografados);
			return cb_gravaDadosCriptografados;
		}

		static int n_GravaDadosCriptografados (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GravaDadosCriptografados ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='gravaDadosCriptografados' and count(parameter)=0]"
		[Register ("gravaDadosCriptografados", "()I", "GetGravaDadosCriptografadosHandler")]
		public virtual unsafe int GravaDadosCriptografados ()
		{
			const string __id = "gravaDadosCriptografados.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_gravaDadosCriptografados_Ljava_lang_String_IarrayBILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGravaDadosCriptografados_Ljava_lang_String_IarrayBILjava_lang_String_Handler ()
		{
			if (cb_gravaDadosCriptografados_Ljava_lang_String_IarrayBILjava_lang_String_ == null)
				cb_gravaDadosCriptografados_Ljava_lang_String_IarrayBILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, int>) n_GravaDadosCriptografados_Ljava_lang_String_IarrayBILjava_lang_String_);
			return cb_gravaDadosCriptografados_Ljava_lang_String_IarrayBILjava_lang_String_;
		}

		static int n_GravaDadosCriptografados_Ljava_lang_String_IarrayBILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GravaDadosCriptografados (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='gravaDadosCriptografados' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("gravaDadosCriptografados", "(Ljava/lang/String;I[BILjava/lang/String;)I", "GetGravaDadosCriptografados_Ljava_lang_String_IarrayBILjava_lang_String_Handler")]
		public virtual unsafe int GravaDadosCriptografados (string p0, int p1, byte[] p2, int p3, string p4)
		{
			const string __id = "gravaDadosCriptografados.(Ljava/lang/String;I[BILjava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_informaProdutoCancelamentoVidalink;
#pragma warning disable 0169
		static Delegate GetInformaProdutoCancelamentoVidalinkHandler ()
		{
			if (cb_informaProdutoCancelamentoVidalink == null)
				cb_informaProdutoCancelamentoVidalink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_InformaProdutoCancelamentoVidalink);
			return cb_informaProdutoCancelamentoVidalink;
		}

		static int n_InformaProdutoCancelamentoVidalink (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InformaProdutoCancelamentoVidalink ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='informaProdutoCancelamentoVidalink' and count(parameter)=0]"
		[Register ("informaProdutoCancelamentoVidalink", "()I", "GetInformaProdutoCancelamentoVidalinkHandler")]
		public virtual unsafe int InformaProdutoCancelamentoVidalink ()
		{
			const string __id = "informaProdutoCancelamentoVidalink.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_informaProdutoCancelamentoVidalink_SLjava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetInformaProdutoCancelamentoVidalink_SLjava_lang_String_SHandler ()
		{
			if (cb_informaProdutoCancelamentoVidalink_SLjava_lang_String_S == null)
				cb_informaProdutoCancelamentoVidalink_SLjava_lang_String_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr, short, int>) n_InformaProdutoCancelamentoVidalink_SLjava_lang_String_S);
			return cb_informaProdutoCancelamentoVidalink_SLjava_lang_String_S;
		}

		static int n_InformaProdutoCancelamentoVidalink_SLjava_lang_String_S (IntPtr jnienv, IntPtr native__this, short p0, IntPtr native_p1, short p2)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.InformaProdutoCancelamentoVidalink (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='informaProdutoCancelamentoVidalink' and count(parameter)=3 and parameter[1][@type='short'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short']]"
		[Register ("informaProdutoCancelamentoVidalink", "(SLjava/lang/String;S)I", "GetInformaProdutoCancelamentoVidalink_SLjava_lang_String_SHandler")]
		public virtual unsafe int InformaProdutoCancelamentoVidalink (short p0, string p1, short p2)
		{
			const string __id = "informaProdutoCancelamentoVidalink.(SLjava/lang/String;S)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_informaProdutoVendaVidalink;
#pragma warning disable 0169
		static Delegate GetInformaProdutoVendaVidalinkHandler ()
		{
			if (cb_informaProdutoVendaVidalink == null)
				cb_informaProdutoVendaVidalink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_InformaProdutoVendaVidalink);
			return cb_informaProdutoVendaVidalink;
		}

		static int n_InformaProdutoVendaVidalink (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InformaProdutoVendaVidalink ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='informaProdutoVendaVidalink' and count(parameter)=0]"
		[Register ("informaProdutoVendaVidalink", "()I", "GetInformaProdutoVendaVidalinkHandler")]
		public virtual unsafe int InformaProdutoVendaVidalink ()
		{
			const string __id = "informaProdutoVendaVidalink.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_informaProdutoVendaVidalink_SLjava_lang_String_SLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInformaProdutoVendaVidalink_SLjava_lang_String_SLjava_lang_String_Handler ()
		{
			if (cb_informaProdutoVendaVidalink_SLjava_lang_String_SLjava_lang_String_ == null)
				cb_informaProdutoVendaVidalink_SLjava_lang_String_SLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr, short, IntPtr, int>) n_InformaProdutoVendaVidalink_SLjava_lang_String_SLjava_lang_String_);
			return cb_informaProdutoVendaVidalink_SLjava_lang_String_SLjava_lang_String_;
		}

		static int n_InformaProdutoVendaVidalink_SLjava_lang_String_SLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, short p0, IntPtr native_p1, short p2, IntPtr native_p3)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.InformaProdutoVendaVidalink (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='informaProdutoVendaVidalink' and count(parameter)=4 and parameter[1][@type='short'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short'] and parameter[4][@type='java.lang.String']]"
		[Register ("informaProdutoVendaVidalink", "(SLjava/lang/String;SLjava/lang/String;)I", "GetInformaProdutoVendaVidalink_SLjava_lang_String_SLjava_lang_String_Handler")]
		public virtual unsafe int InformaProdutoVendaVidalink (short p0, string p1, short p2, string p3)
		{
			const string __id = "informaProdutoVendaVidalink.(SLjava/lang/String;SLjava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_informaTotalizadorVenda;
#pragma warning disable 0169
		static Delegate GetInformaTotalizadorVendaHandler ()
		{
			if (cb_informaTotalizadorVenda == null)
				cb_informaTotalizadorVenda = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_InformaTotalizadorVenda);
			return cb_informaTotalizadorVenda;
		}

		static int n_InformaTotalizadorVenda (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InformaTotalizadorVenda ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='informaTotalizadorVenda' and count(parameter)=0]"
		[Register ("informaTotalizadorVenda", "()I", "GetInformaTotalizadorVendaHandler")]
		public virtual unsafe int InformaTotalizadorVenda ()
		{
			const string __id = "informaTotalizadorVenda.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_informaTotalizadorVenda_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInformaTotalizadorVenda_Ljava_lang_String_Handler ()
		{
			if (cb_informaTotalizadorVenda_Ljava_lang_String_ == null)
				cb_informaTotalizadorVenda_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_InformaTotalizadorVenda_Ljava_lang_String_);
			return cb_informaTotalizadorVenda_Ljava_lang_String_;
		}

		static int n_InformaTotalizadorVenda_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.InformaTotalizadorVenda (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='informaTotalizadorVenda' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("informaTotalizadorVenda", "(Ljava/lang/String;)I", "GetInformaTotalizadorVenda_Ljava_lang_String_Handler")]
		public virtual unsafe int InformaTotalizadorVenda (string p0)
		{
			const string __id = "informaTotalizadorVenda.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_iniciaCancelamentoIdentificadoSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetIniciaCancelamentoIdentificadoSiTefInterativoHandler ()
		{
			if (cb_iniciaCancelamentoIdentificadoSiTefInterativo == null)
				cb_iniciaCancelamentoIdentificadoSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IniciaCancelamentoIdentificadoSiTefInterativo);
			return cb_iniciaCancelamentoIdentificadoSiTefInterativo;
		}

		static int n_IniciaCancelamentoIdentificadoSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IniciaCancelamentoIdentificadoSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaCancelamentoIdentificadoSiTefInterativo' and count(parameter)=0]"
		[Register ("iniciaCancelamentoIdentificadoSiTefInterativo", "()I", "GetIniciaCancelamentoIdentificadoSiTefInterativoHandler")]
		public virtual unsafe int IniciaCancelamentoIdentificadoSiTefInterativo ()
		{
			const string __id = "iniciaCancelamentoIdentificadoSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iniciaCancelamentoIdentificadoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciaCancelamentoIdentificadoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciaCancelamentoIdentificadoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciaCancelamentoIdentificadoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_IniciaCancelamentoIdentificadoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_iniciaCancelamentoIdentificadoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_IniciaCancelamentoIdentificadoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IniciaCancelamentoIdentificadoSiTefInterativo (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaCancelamentoIdentificadoSiTefInterativo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("iniciaCancelamentoIdentificadoSiTefInterativo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetIniciaCancelamentoIdentificadoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IniciaCancelamentoIdentificadoSiTefInterativo (string p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "iniciaCancelamentoIdentificadoSiTefInterativo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_iniciaCancelamentoPagamentoContasSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetIniciaCancelamentoPagamentoContasSiTefInterativoHandler ()
		{
			if (cb_iniciaCancelamentoPagamentoContasSiTefInterativo == null)
				cb_iniciaCancelamentoPagamentoContasSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IniciaCancelamentoPagamentoContasSiTefInterativo);
			return cb_iniciaCancelamentoPagamentoContasSiTefInterativo;
		}

		static int n_IniciaCancelamentoPagamentoContasSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IniciaCancelamentoPagamentoContasSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaCancelamentoPagamentoContasSiTefInterativo' and count(parameter)=0]"
		[Register ("iniciaCancelamentoPagamentoContasSiTefInterativo", "()I", "GetIniciaCancelamentoPagamentoContasSiTefInterativoHandler")]
		public virtual unsafe int IniciaCancelamentoPagamentoContasSiTefInterativo ()
		{
			const string __id = "iniciaCancelamentoPagamentoContasSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iniciaCancelamentoPagamentoContasSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciaCancelamentoPagamentoContasSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciaCancelamentoPagamentoContasSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciaCancelamentoPagamentoContasSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_IniciaCancelamentoPagamentoContasSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_iniciaCancelamentoPagamentoContasSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_IniciaCancelamentoPagamentoContasSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IniciaCancelamentoPagamentoContasSiTefInterativo (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaCancelamentoPagamentoContasSiTefInterativo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("iniciaCancelamentoPagamentoContasSiTefInterativo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetIniciaCancelamentoPagamentoContasSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IniciaCancelamentoPagamentoContasSiTefInterativo (string p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "iniciaCancelamentoPagamentoContasSiTefInterativo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_iniciaConfiguracaoSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetIniciaConfiguracaoSiTefInterativoHandler ()
		{
			if (cb_iniciaConfiguracaoSiTefInterativo == null)
				cb_iniciaConfiguracaoSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IniciaConfiguracaoSiTefInterativo);
			return cb_iniciaConfiguracaoSiTefInterativo;
		}

		static int n_IniciaConfiguracaoSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IniciaConfiguracaoSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaConfiguracaoSiTefInterativo' and count(parameter)=0]"
		[Register ("iniciaConfiguracaoSiTefInterativo", "()I", "GetIniciaConfiguracaoSiTefInterativoHandler")]
		public virtual unsafe int IniciaConfiguracaoSiTefInterativo ()
		{
			const string __id = "iniciaConfiguracaoSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iniciaConfiguracaoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciaConfiguracaoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciaConfiguracaoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciaConfiguracaoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_IniciaConfiguracaoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_iniciaConfiguracaoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_IniciaConfiguracaoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IniciaConfiguracaoSiTefInterativo (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaConfiguracaoSiTefInterativo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("iniciaConfiguracaoSiTefInterativo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetIniciaConfiguracaoSiTefInterativo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IniciaConfiguracaoSiTefInterativo (string p0, string p1, string p2)
		{
			const string __id = "iniciaConfiguracaoSiTefInterativo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_iniciaFuncaoAASiTefInterativo;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoAASiTefInterativoHandler ()
		{
			if (cb_iniciaFuncaoAASiTefInterativo == null)
				cb_iniciaFuncaoAASiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IniciaFuncaoAASiTefInterativo);
			return cb_iniciaFuncaoAASiTefInterativo;
		}

		static int n_IniciaFuncaoAASiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IniciaFuncaoAASiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoAASiTefInterativo' and count(parameter)=0]"
		[Register ("iniciaFuncaoAASiTefInterativo", "()I", "GetIniciaFuncaoAASiTefInterativoHandler")]
		public virtual unsafe int IniciaFuncaoAASiTefInterativo ()
		{
			const string __id = "iniciaFuncaoAASiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iniciaFuncaoAASiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoAASiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciaFuncaoAASiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciaFuncaoAASiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_IniciaFuncaoAASiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_iniciaFuncaoAASiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_IniciaFuncaoAASiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IniciaFuncaoAASiTefInterativo (p0, p1, p2, p3, p4, p5, p6, p7);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoAASiTefInterativo' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("iniciaFuncaoAASiTefInterativo", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetIniciaFuncaoAASiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IniciaFuncaoAASiTefInterativo (int p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7)
		{
			const string __id = "iniciaFuncaoAASiTefInterativo.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (native_p7);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativo;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativoHandler ()
		{
			if (cb_iniciaFuncaoSiTefInterativo == null)
				cb_iniciaFuncaoSiTefInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativo);
			return cb_iniciaFuncaoSiTefInterativo;
		}

		static int n_IniciaFuncaoSiTefInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IniciaFuncaoSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativo' and count(parameter)=0]"
		[Register ("iniciaFuncaoSiTefInterativo", "()I", "GetIniciaFuncaoSiTefInterativoHandler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativo ()
		{
			const string __id = "iniciaFuncaoSiTefInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciaFuncaoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciaFuncaoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_iniciaFuncaoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_IniciaFuncaoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IniciaFuncaoSiTefInterativo (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativo' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("iniciaFuncaoSiTefInterativo", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetIniciaFuncaoSiTefInterativo_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativo (int p0, string p1, string p2, string p3, string p4, string p5, string p6)
		{
			const string __id = "iniciaFuncaoSiTefInterativo.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativoCancelamentoVidalink;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativoCancelamentoVidalinkHandler ()
		{
			if (cb_iniciaFuncaoSiTefInterativoCancelamentoVidalink == null)
				cb_iniciaFuncaoSiTefInterativoCancelamentoVidalink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativoCancelamentoVidalink);
			return cb_iniciaFuncaoSiTefInterativoCancelamentoVidalink;
		}

		static int n_IniciaFuncaoSiTefInterativoCancelamentoVidalink (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IniciaFuncaoSiTefInterativoCancelamentoVidalink ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativoCancelamentoVidalink' and count(parameter)=0]"
		[Register ("iniciaFuncaoSiTefInterativoCancelamentoVidalink", "()I", "GetIniciaFuncaoSiTefInterativoCancelamentoVidalinkHandler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativoCancelamentoVidalink ()
		{
			const string __id = "iniciaFuncaoSiTefInterativoCancelamentoVidalink.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativoCancelamentoVidalink_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativoCancelamentoVidalink_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciaFuncaoSiTefInterativoCancelamentoVidalink_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciaFuncaoSiTefInterativoCancelamentoVidalink_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, short, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativoCancelamentoVidalink_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_iniciaFuncaoSiTefInterativoCancelamentoVidalink_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_IniciaFuncaoSiTefInterativoCancelamentoVidalink_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, short p0, short p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			string p8 = JNIEnv.GetString (native_p8, JniHandleOwnership.DoNotTransfer);
			string p9 = JNIEnv.GetString (native_p9, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IniciaFuncaoSiTefInterativoCancelamentoVidalink (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativoCancelamentoVidalink' and count(parameter)=10 and parameter[1][@type='short'] and parameter[2][@type='short'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String']]"
		[Register ("iniciaFuncaoSiTefInterativoCancelamentoVidalink", "(SSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetIniciaFuncaoSiTefInterativoCancelamentoVidalink_SSLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativoCancelamentoVidalink (short p0, short p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9)
		{
			const string __id = "iniciaFuncaoSiTefInterativoCancelamentoVidalink.(SSLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (native_p7);
				__args [8] = new JniArgumentValue (native_p8);
				__args [9] = new JniArgumentValue (native_p9);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativoConsultaPBM;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativoConsultaPBMHandler ()
		{
			if (cb_iniciaFuncaoSiTefInterativoConsultaPBM == null)
				cb_iniciaFuncaoSiTefInterativoConsultaPBM = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativoConsultaPBM);
			return cb_iniciaFuncaoSiTefInterativoConsultaPBM;
		}

		static int n_IniciaFuncaoSiTefInterativoConsultaPBM (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IniciaFuncaoSiTefInterativoConsultaPBM ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativoConsultaPBM' and count(parameter)=0]"
		[Register ("iniciaFuncaoSiTefInterativoConsultaPBM", "()I", "GetIniciaFuncaoSiTefInterativoConsultaPBMHandler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativoConsultaPBM ()
		{
			const string __id = "iniciaFuncaoSiTefInterativoConsultaPBM.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativoConsultaPBM_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativoConsultaPBM_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciaFuncaoSiTefInterativoConsultaPBM_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciaFuncaoSiTefInterativoConsultaPBM_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativoConsultaPBM_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_iniciaFuncaoSiTefInterativoConsultaPBM_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_IniciaFuncaoSiTefInterativoConsultaPBM_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IniciaFuncaoSiTefInterativoConsultaPBM (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativoConsultaPBM' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("iniciaFuncaoSiTefInterativoConsultaPBM", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetIniciaFuncaoSiTefInterativoConsultaPBM_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativoConsultaPBM (string p0, string p1, string p2, string p3, string p4, string p5, string p6)
		{
			const string __id = "iniciaFuncaoSiTefInterativoConsultaPBM.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativoConsultaVidalink;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativoConsultaVidalinkHandler ()
		{
			if (cb_iniciaFuncaoSiTefInterativoConsultaVidalink == null)
				cb_iniciaFuncaoSiTefInterativoConsultaVidalink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativoConsultaVidalink);
			return cb_iniciaFuncaoSiTefInterativoConsultaVidalink;
		}

		static int n_IniciaFuncaoSiTefInterativoConsultaVidalink (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IniciaFuncaoSiTefInterativoConsultaVidalink ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativoConsultaVidalink' and count(parameter)=0]"
		[Register ("iniciaFuncaoSiTefInterativoConsultaVidalink", "()I", "GetIniciaFuncaoSiTefInterativoConsultaVidalinkHandler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativoConsultaVidalink ()
		{
			const string __id = "iniciaFuncaoSiTefInterativoConsultaVidalink.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativoConsultaVidalink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativoConsultaVidalink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciaFuncaoSiTefInterativoConsultaVidalink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciaFuncaoSiTefInterativoConsultaVidalink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativoConsultaVidalink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_iniciaFuncaoSiTefInterativoConsultaVidalink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_IniciaFuncaoSiTefInterativoConsultaVidalink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IniciaFuncaoSiTefInterativoConsultaVidalink (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativoConsultaVidalink' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("iniciaFuncaoSiTefInterativoConsultaVidalink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetIniciaFuncaoSiTefInterativoConsultaVidalink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativoConsultaVidalink (string p0, string p1, string p2, string p3, string p4, string p5)
		{
			const string __id = "iniciaFuncaoSiTefInterativoConsultaVidalink.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativoVendaVidalink;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativoVendaVidalinkHandler ()
		{
			if (cb_iniciaFuncaoSiTefInterativoVendaVidalink == null)
				cb_iniciaFuncaoSiTefInterativoVendaVidalink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativoVendaVidalink);
			return cb_iniciaFuncaoSiTefInterativoVendaVidalink;
		}

		static int n_IniciaFuncaoSiTefInterativoVendaVidalink (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IniciaFuncaoSiTefInterativoVendaVidalink ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativoVendaVidalink' and count(parameter)=0]"
		[Register ("iniciaFuncaoSiTefInterativoVendaVidalink", "()I", "GetIniciaFuncaoSiTefInterativoVendaVidalinkHandler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativoVendaVidalink ()
		{
			const string __id = "iniciaFuncaoSiTefInterativoVendaVidalink.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iniciaFuncaoSiTefInterativoVendaVidalink_Ljava_lang_String_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciaFuncaoSiTefInterativoVendaVidalink_Ljava_lang_String_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciaFuncaoSiTefInterativoVendaVidalink_Ljava_lang_String_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciaFuncaoSiTefInterativoVendaVidalink_Ljava_lang_String_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, short, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_IniciaFuncaoSiTefInterativoVendaVidalink_Ljava_lang_String_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_iniciaFuncaoSiTefInterativoVendaVidalink_Ljava_lang_String_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_IniciaFuncaoSiTefInterativoVendaVidalink_Ljava_lang_String_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IniciaFuncaoSiTefInterativoVendaVidalink (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='iniciaFuncaoSiTefInterativoVendaVidalink' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("iniciaFuncaoSiTefInterativoVendaVidalink", "(Ljava/lang/String;SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetIniciaFuncaoSiTefInterativoVendaVidalink_Ljava_lang_String_SLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int IniciaFuncaoSiTefInterativoVendaVidalink (string p0, short p1, string p2, string p3, string p4, string p5)
		{
			const string __id = "iniciaFuncaoSiTefInterativoVendaVidalink.(Ljava/lang/String;SLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_interrompeLeCartaoDireto;
#pragma warning disable 0169
		static Delegate GetInterrompeLeCartaoDiretoHandler ()
		{
			if (cb_interrompeLeCartaoDireto == null)
				cb_interrompeLeCartaoDireto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_InterrompeLeCartaoDireto);
			return cb_interrompeLeCartaoDireto;
		}

		static int n_InterrompeLeCartaoDireto (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InterrompeLeCartaoDireto ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='interrompeLeCartaoDireto' and count(parameter)=0]"
		[Register ("interrompeLeCartaoDireto", "()I", "GetInterrompeLeCartaoDiretoHandler")]
		public virtual unsafe int InterrompeLeCartaoDireto ()
		{
			const string __id = "interrompeLeCartaoDireto.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leCampoCriptografadoPinPad;
#pragma warning disable 0169
		static Delegate GetLeCampoCriptografadoPinPadHandler ()
		{
			if (cb_leCampoCriptografadoPinPad == null)
				cb_leCampoCriptografadoPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeCampoCriptografadoPinPad);
			return cb_leCampoCriptografadoPinPad;
		}

		static int n_LeCampoCriptografadoPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeCampoCriptografadoPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCampoCriptografadoPinPad' and count(parameter)=0]"
		[Register ("leCampoCriptografadoPinPad", "()I", "GetLeCampoCriptografadoPinPadHandler")]
		public virtual unsafe int LeCampoCriptografadoPinPad ()
		{
			const string __id = "leCampoCriptografadoPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leCampoCriptografadoPinPad_Ljava_lang_String_Ljava_lang_String_SS;
#pragma warning disable 0169
		static Delegate GetLeCampoCriptografadoPinPad_Ljava_lang_String_Ljava_lang_String_SSHandler ()
		{
			if (cb_leCampoCriptografadoPinPad_Ljava_lang_String_Ljava_lang_String_SS == null)
				cb_leCampoCriptografadoPinPad_Ljava_lang_String_Ljava_lang_String_SS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, short, short, int>) n_LeCampoCriptografadoPinPad_Ljava_lang_String_Ljava_lang_String_SS);
			return cb_leCampoCriptografadoPinPad_Ljava_lang_String_Ljava_lang_String_SS;
		}

		static int n_LeCampoCriptografadoPinPad_Ljava_lang_String_Ljava_lang_String_SS (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, short p2, short p3)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeCampoCriptografadoPinPad (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCampoCriptografadoPinPad' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short'] and parameter[4][@type='short']]"
		[Register ("leCampoCriptografadoPinPad", "(Ljava/lang/String;Ljava/lang/String;SS)I", "GetLeCampoCriptografadoPinPad_Ljava_lang_String_Ljava_lang_String_SSHandler")]
		public virtual unsafe int LeCampoCriptografadoPinPad (string p0, string p1, short p2, short p3)
		{
			const string __id = "leCampoCriptografadoPinPad.(Ljava/lang/String;Ljava/lang/String;SS)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_leCampoPinPad;
#pragma warning disable 0169
		static Delegate GetLeCampoPinPadHandler ()
		{
			if (cb_leCampoPinPad == null)
				cb_leCampoPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeCampoPinPad);
			return cb_leCampoPinPad;
		}

		static int n_LeCampoPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeCampoPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCampoPinPad' and count(parameter)=0]"
		[Register ("leCampoPinPad", "()I", "GetLeCampoPinPadHandler")]
		public virtual unsafe int LeCampoPinPad ()
		{
			const string __id = "leCampoPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leCampoPinPad_Ljava_lang_String_SS;
#pragma warning disable 0169
		static Delegate GetLeCampoPinPad_Ljava_lang_String_SSHandler ()
		{
			if (cb_leCampoPinPad_Ljava_lang_String_SS == null)
				cb_leCampoPinPad_Ljava_lang_String_SS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, short, short, int>) n_LeCampoPinPad_Ljava_lang_String_SS);
			return cb_leCampoPinPad_Ljava_lang_String_SS;
		}

		static int n_LeCampoPinPad_Ljava_lang_String_SS (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1, short p2)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeCampoPinPad (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCampoPinPad' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short'] and parameter[3][@type='short']]"
		[Register ("leCampoPinPad", "(Ljava/lang/String;SS)I", "GetLeCampoPinPad_Ljava_lang_String_SSHandler")]
		public virtual unsafe int LeCampoPinPad (string p0, short p1, short p2)
		{
			const string __id = "leCampoPinPad.(Ljava/lang/String;SS)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leCartaoDireto;
#pragma warning disable 0169
		static Delegate GetLeCartaoDiretoHandler ()
		{
			if (cb_leCartaoDireto == null)
				cb_leCartaoDireto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeCartaoDireto);
			return cb_leCartaoDireto;
		}

		static int n_LeCartaoDireto (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeCartaoDireto ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoDireto' and count(parameter)=0]"
		[Register ("leCartaoDireto", "()I", "GetLeCartaoDiretoHandler")]
		public virtual unsafe int LeCartaoDireto ()
		{
			const string __id = "leCartaoDireto.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leCartaoDireto_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeCartaoDireto_Ljava_lang_String_Handler ()
		{
			if (cb_leCartaoDireto_Ljava_lang_String_ == null)
				cb_leCartaoDireto_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeCartaoDireto_Ljava_lang_String_);
			return cb_leCartaoDireto_Ljava_lang_String_;
		}

		static int n_LeCartaoDireto_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeCartaoDireto (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoDireto' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leCartaoDireto", "(Ljava/lang/String;)I", "GetLeCartaoDireto_Ljava_lang_String_Handler")]
		public virtual unsafe int LeCartaoDireto (string p0)
		{
			const string __id = "leCartaoDireto.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leCartaoDiretoEx;
#pragma warning disable 0169
		static Delegate GetLeCartaoDiretoExHandler ()
		{
			if (cb_leCartaoDiretoEx == null)
				cb_leCartaoDiretoEx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeCartaoDiretoEx);
			return cb_leCartaoDiretoEx;
		}

		static int n_LeCartaoDiretoEx (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeCartaoDiretoEx ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoDiretoEx' and count(parameter)=0]"
		[Register ("leCartaoDiretoEx", "()I", "GetLeCartaoDiretoExHandler")]
		public virtual unsafe int LeCartaoDiretoEx ()
		{
			const string __id = "leCartaoDiretoEx.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leCartaoDiretoEx_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetLeCartaoDiretoEx_Ljava_lang_String_SHandler ()
		{
			if (cb_leCartaoDiretoEx_Ljava_lang_String_S == null)
				cb_leCartaoDiretoEx_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, short, int>) n_LeCartaoDiretoEx_Ljava_lang_String_S);
			return cb_leCartaoDiretoEx_Ljava_lang_String_S;
		}

		static int n_LeCartaoDiretoEx_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeCartaoDiretoEx (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoDiretoEx' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short']]"
		[Register ("leCartaoDiretoEx", "(Ljava/lang/String;S)I", "GetLeCartaoDiretoEx_Ljava_lang_String_SHandler")]
		public virtual unsafe int LeCartaoDiretoEx (string p0, short p1)
		{
			const string __id = "leCartaoDiretoEx.(Ljava/lang/String;S)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leCartaoDiretoSeguro;
#pragma warning disable 0169
		static Delegate GetLeCartaoDiretoSeguroHandler ()
		{
			if (cb_leCartaoDiretoSeguro == null)
				cb_leCartaoDiretoSeguro = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeCartaoDiretoSeguro);
			return cb_leCartaoDiretoSeguro;
		}

		static int n_LeCartaoDiretoSeguro (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeCartaoDiretoSeguro ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoDiretoSeguro' and count(parameter)=0]"
		[Register ("leCartaoDiretoSeguro", "()I", "GetLeCartaoDiretoSeguroHandler")]
		public virtual unsafe int LeCartaoDiretoSeguro ()
		{
			const string __id = "leCartaoDiretoSeguro.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leCartaoDiretoSeguro_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetLeCartaoDiretoSeguro_Ljava_lang_String_SHandler ()
		{
			if (cb_leCartaoDiretoSeguro_Ljava_lang_String_S == null)
				cb_leCartaoDiretoSeguro_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, short, int>) n_LeCartaoDiretoSeguro_Ljava_lang_String_S);
			return cb_leCartaoDiretoSeguro_Ljava_lang_String_S;
		}

		static int n_LeCartaoDiretoSeguro_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeCartaoDiretoSeguro (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoDiretoSeguro' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short']]"
		[Register ("leCartaoDiretoSeguro", "(Ljava/lang/String;S)I", "GetLeCartaoDiretoSeguro_Ljava_lang_String_SHandler")]
		public virtual unsafe int LeCartaoDiretoSeguro (string p0, short p1)
		{
			const string __id = "leCartaoDiretoSeguro.(Ljava/lang/String;S)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leCartaoInterativo;
#pragma warning disable 0169
		static Delegate GetLeCartaoInterativoHandler ()
		{
			if (cb_leCartaoInterativo == null)
				cb_leCartaoInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeCartaoInterativo);
			return cb_leCartaoInterativo;
		}

		static int n_LeCartaoInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeCartaoInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoInterativo' and count(parameter)=0]"
		[Register ("leCartaoInterativo", "()I", "GetLeCartaoInterativoHandler")]
		public virtual unsafe int LeCartaoInterativo ()
		{
			const string __id = "leCartaoInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leCartaoInterativo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeCartaoInterativo_Ljava_lang_String_Handler ()
		{
			if (cb_leCartaoInterativo_Ljava_lang_String_ == null)
				cb_leCartaoInterativo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeCartaoInterativo_Ljava_lang_String_);
			return cb_leCartaoInterativo_Ljava_lang_String_;
		}

		static int n_LeCartaoInterativo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeCartaoInterativo (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoInterativo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leCartaoInterativo", "(Ljava/lang/String;)I", "GetLeCartaoInterativo_Ljava_lang_String_Handler")]
		public virtual unsafe int LeCartaoInterativo (string p0)
		{
			const string __id = "leCartaoInterativo.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leCartaoSeguro;
#pragma warning disable 0169
		static Delegate GetLeCartaoSeguroHandler ()
		{
			if (cb_leCartaoSeguro == null)
				cb_leCartaoSeguro = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeCartaoSeguro);
			return cb_leCartaoSeguro;
		}

		static int n_LeCartaoSeguro (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeCartaoSeguro ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoSeguro' and count(parameter)=0]"
		[Register ("leCartaoSeguro", "()I", "GetLeCartaoSeguroHandler")]
		public virtual unsafe int LeCartaoSeguro ()
		{
			const string __id = "leCartaoSeguro.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leCartaoSeguro_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeCartaoSeguro_Ljava_lang_String_Handler ()
		{
			if (cb_leCartaoSeguro_Ljava_lang_String_ == null)
				cb_leCartaoSeguro_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeCartaoSeguro_Ljava_lang_String_);
			return cb_leCartaoSeguro_Ljava_lang_String_;
		}

		static int n_LeCartaoSeguro_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeCartaoSeguro (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leCartaoSeguro' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leCartaoSeguro", "(Ljava/lang/String;)I", "GetLeCartaoSeguro_Ljava_lang_String_Handler")]
		public virtual unsafe int LeCartaoSeguro (string p0)
		{
			const string __id = "leCartaoSeguro.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leDigitoPinPad;
#pragma warning disable 0169
		static Delegate GetLeDigitoPinPadHandler ()
		{
			if (cb_leDigitoPinPad == null)
				cb_leDigitoPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeDigitoPinPad);
			return cb_leDigitoPinPad;
		}

		static int n_LeDigitoPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeDigitoPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leDigitoPinPad' and count(parameter)=0]"
		[Register ("leDigitoPinPad", "()I", "GetLeDigitoPinPadHandler")]
		public virtual unsafe int LeDigitoPinPad ()
		{
			const string __id = "leDigitoPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leDigitoPinPad_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeDigitoPinPad_Ljava_lang_String_Handler ()
		{
			if (cb_leDigitoPinPad_Ljava_lang_String_ == null)
				cb_leDigitoPinPad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeDigitoPinPad_Ljava_lang_String_);
			return cb_leDigitoPinPad_Ljava_lang_String_;
		}

		static int n_LeDigitoPinPad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeDigitoPinPad (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leDigitoPinPad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leDigitoPinPad", "(Ljava/lang/String;)I", "GetLeDigitoPinPad_Ljava_lang_String_Handler")]
		public virtual unsafe int LeDigitoPinPad (string p0)
		{
			const string __id = "leDigitoPinPad.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leDoisDigitosPinPad;
#pragma warning disable 0169
		static Delegate GetLeDoisDigitosPinPadHandler ()
		{
			if (cb_leDoisDigitosPinPad == null)
				cb_leDoisDigitosPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeDoisDigitosPinPad);
			return cb_leDoisDigitosPinPad;
		}

		static int n_LeDoisDigitosPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeDoisDigitosPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leDoisDigitosPinPad' and count(parameter)=0]"
		[Register ("leDoisDigitosPinPad", "()I", "GetLeDoisDigitosPinPadHandler")]
		public virtual unsafe int LeDoisDigitosPinPad ()
		{
			const string __id = "leDoisDigitosPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leDoisDigitosPinPad_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeDoisDigitosPinPad_Ljava_lang_String_Handler ()
		{
			if (cb_leDoisDigitosPinPad_Ljava_lang_String_ == null)
				cb_leDoisDigitosPinPad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeDoisDigitosPinPad_Ljava_lang_String_);
			return cb_leDoisDigitosPinPad_Ljava_lang_String_;
		}

		static int n_LeDoisDigitosPinPad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeDoisDigitosPinPad (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leDoisDigitosPinPad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leDoisDigitosPinPad", "(Ljava/lang/String;)I", "GetLeDoisDigitosPinPad_Ljava_lang_String_Handler")]
		public virtual unsafe int LeDoisDigitosPinPad (string p0)
		{
			const string __id = "leDoisDigitosPinPad.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leSenhaDireto;
#pragma warning disable 0169
		static Delegate GetLeSenhaDiretoHandler ()
		{
			if (cb_leSenhaDireto == null)
				cb_leSenhaDireto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeSenhaDireto);
			return cb_leSenhaDireto;
		}

		static int n_LeSenhaDireto (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeSenhaDireto ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leSenhaDireto' and count(parameter)=0]"
		[Register ("leSenhaDireto", "()I", "GetLeSenhaDiretoHandler")]
		public virtual unsafe int LeSenhaDireto ()
		{
			const string __id = "leSenhaDireto.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leSenhaDireto_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeSenhaDireto_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_leSenhaDireto_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_leSenhaDireto_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LeSenhaDireto_Ljava_lang_String_Ljava_lang_String_);
			return cb_leSenhaDireto_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_LeSenhaDireto_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeSenhaDireto (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leSenhaDireto' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("leSenhaDireto", "(Ljava/lang/String;Ljava/lang/String;)I", "GetLeSenhaDireto_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int LeSenhaDireto (string p0, string p1)
		{
			const string __id = "leSenhaDireto.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_leSenhaDiretoEx;
#pragma warning disable 0169
		static Delegate GetLeSenhaDiretoExHandler ()
		{
			if (cb_leSenhaDiretoEx == null)
				cb_leSenhaDiretoEx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeSenhaDiretoEx);
			return cb_leSenhaDiretoEx;
		}

		static int n_LeSenhaDiretoEx (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeSenhaDiretoEx ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leSenhaDiretoEx' and count(parameter)=0]"
		[Register ("leSenhaDiretoEx", "()I", "GetLeSenhaDiretoExHandler")]
		public virtual unsafe int LeSenhaDiretoEx ()
		{
			const string __id = "leSenhaDiretoEx.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leSenhaDiretoEx_Ljava_lang_String_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetLeSenhaDiretoEx_Ljava_lang_String_Ljava_lang_String_SHandler ()
		{
			if (cb_leSenhaDiretoEx_Ljava_lang_String_Ljava_lang_String_S == null)
				cb_leSenhaDiretoEx_Ljava_lang_String_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, short, int>) n_LeSenhaDiretoEx_Ljava_lang_String_Ljava_lang_String_S);
			return cb_leSenhaDiretoEx_Ljava_lang_String_Ljava_lang_String_S;
		}

		static int n_LeSenhaDiretoEx_Ljava_lang_String_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, short p2)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeSenhaDiretoEx (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leSenhaDiretoEx' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='short']]"
		[Register ("leSenhaDiretoEx", "(Ljava/lang/String;Ljava/lang/String;S)I", "GetLeSenhaDiretoEx_Ljava_lang_String_Ljava_lang_String_SHandler")]
		public virtual unsafe int LeSenhaDiretoEx (string p0, string p1, short p2)
		{
			const string __id = "leSenhaDiretoEx.(Ljava/lang/String;Ljava/lang/String;S)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_leSenhaInterativo;
#pragma warning disable 0169
		static Delegate GetLeSenhaInterativoHandler ()
		{
			if (cb_leSenhaInterativo == null)
				cb_leSenhaInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeSenhaInterativo);
			return cb_leSenhaInterativo;
		}

		static int n_LeSenhaInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeSenhaInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leSenhaInterativo' and count(parameter)=0]"
		[Register ("leSenhaInterativo", "()I", "GetLeSenhaInterativoHandler")]
		public virtual unsafe int LeSenhaInterativo ()
		{
			const string __id = "leSenhaInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leSenhaInterativo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeSenhaInterativo_Ljava_lang_String_Handler ()
		{
			if (cb_leSenhaInterativo_Ljava_lang_String_ == null)
				cb_leSenhaInterativo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeSenhaInterativo_Ljava_lang_String_);
			return cb_leSenhaInterativo_Ljava_lang_String_;
		}

		static int n_LeSenhaInterativo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeSenhaInterativo (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leSenhaInterativo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leSenhaInterativo", "(Ljava/lang/String;)I", "GetLeSenhaInterativo_Ljava_lang_String_Handler")]
		public virtual unsafe int LeSenhaInterativo (string p0)
		{
			const string __id = "leSenhaInterativo.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leSimNaoPinPad;
#pragma warning disable 0169
		static Delegate GetLeSimNaoPinPadHandler ()
		{
			if (cb_leSimNaoPinPad == null)
				cb_leSimNaoPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeSimNaoPinPad);
			return cb_leSimNaoPinPad;
		}

		static int n_LeSimNaoPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeSimNaoPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leSimNaoPinPad' and count(parameter)=0]"
		[Register ("leSimNaoPinPad", "()I", "GetLeSimNaoPinPadHandler")]
		public virtual unsafe int LeSimNaoPinPad ()
		{
			const string __id = "leSimNaoPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leSimNaoPinPad_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeSimNaoPinPad_Ljava_lang_String_Handler ()
		{
			if (cb_leSimNaoPinPad_Ljava_lang_String_ == null)
				cb_leSimNaoPinPad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeSimNaoPinPad_Ljava_lang_String_);
			return cb_leSimNaoPinPad_Ljava_lang_String_;
		}

		static int n_LeSimNaoPinPad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeSimNaoPinPad (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leSimNaoPinPad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leSimNaoPinPad", "(Ljava/lang/String;)I", "GetLeSimNaoPinPad_Ljava_lang_String_Handler")]
		public virtual unsafe int LeSimNaoPinPad (string p0)
		{
			const string __id = "leSimNaoPinPad.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leTeclaPinPad;
#pragma warning disable 0169
		static Delegate GetLeTeclaPinPadHandler ()
		{
			if (cb_leTeclaPinPad == null)
				cb_leTeclaPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeTeclaPinPad);
			return cb_leTeclaPinPad;
		}

		static int n_LeTeclaPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeTeclaPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leTeclaPinPad' and count(parameter)=0]"
		[Register ("leTeclaPinPad", "()I", "GetLeTeclaPinPadHandler")]
		public virtual unsafe int LeTeclaPinPad ()
		{
			const string __id = "leTeclaPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leTrilha3;
#pragma warning disable 0169
		static Delegate GetLeTrilha3Handler ()
		{
			if (cb_leTrilha3 == null)
				cb_leTrilha3 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeTrilha3);
			return cb_leTrilha3;
		}

		static int n_LeTrilha3 (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeTrilha3 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leTrilha3' and count(parameter)=0]"
		[Register ("leTrilha3", "()I", "GetLeTrilha3Handler")]
		public virtual unsafe int LeTrilha3 ()
		{
			const string __id = "leTrilha3.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_leTrilha3_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeTrilha3_Ljava_lang_String_Handler ()
		{
			if (cb_leTrilha3_Ljava_lang_String_ == null)
				cb_leTrilha3_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeTrilha3_Ljava_lang_String_);
			return cb_leTrilha3_Ljava_lang_String_;
		}

		static int n_LeTrilha3_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeTrilha3 (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leTrilha3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leTrilha3", "(Ljava/lang/String;)I", "GetLeTrilha3_Ljava_lang_String_Handler")]
		public virtual unsafe int LeTrilha3 (string p0)
		{
			const string __id = "leTrilha3.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leTrilhaChipInterativo;
#pragma warning disable 0169
		static Delegate GetLeTrilhaChipInterativoHandler ()
		{
			if (cb_leTrilhaChipInterativo == null)
				cb_leTrilhaChipInterativo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LeTrilhaChipInterativo);
			return cb_leTrilhaChipInterativo;
		}

		static int n_LeTrilhaChipInterativo (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeTrilhaChipInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='leTrilhaChipInterativo' and count(parameter)=0]"
		[Register ("leTrilhaChipInterativo", "()I", "GetLeTrilhaChipInterativoHandler")]
		public virtual unsafe int LeTrilhaChipInterativo ()
		{
			const string __id = "leTrilhaChipInterativo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemChaveSeguranca;
#pragma warning disable 0169
		static Delegate GetObtemChaveSegurancaHandler ()
		{
			if (cb_obtemChaveSeguranca == null)
				cb_obtemChaveSeguranca = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemChaveSeguranca);
			return cb_obtemChaveSeguranca;
		}

		static int n_ObtemChaveSeguranca (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemChaveSeguranca ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemChaveSeguranca' and count(parameter)=0]"
		[Register ("obtemChaveSeguranca", "()I", "GetObtemChaveSegurancaHandler")]
		public virtual unsafe int ObtemChaveSeguranca ()
		{
			const string __id = "obtemChaveSeguranca.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemChaveSeguranca_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtemChaveSeguranca_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_obtemChaveSeguranca_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_obtemChaveSeguranca_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ObtemChaveSeguranca_Ljava_lang_String_Ljava_lang_String_);
			return cb_obtemChaveSeguranca_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ObtemChaveSeguranca_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemChaveSeguranca (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemChaveSeguranca' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("obtemChaveSeguranca", "(Ljava/lang/String;Ljava/lang/String;)I", "GetObtemChaveSeguranca_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ObtemChaveSeguranca (string p0, string p1)
		{
			const string __id = "obtemChaveSeguranca.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_obtemDadoPinPad;
#pragma warning disable 0169
		static Delegate GetObtemDadoPinPadHandler ()
		{
			if (cb_obtemDadoPinPad == null)
				cb_obtemDadoPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemDadoPinPad);
			return cb_obtemDadoPinPad;
		}

		static int n_ObtemDadoPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemDadoPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadoPinPad' and count(parameter)=0]"
		[Register ("obtemDadoPinPad", "()I", "GetObtemDadoPinPadHandler")]
		public virtual unsafe int ObtemDadoPinPad ()
		{
			const string __id = "obtemDadoPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemDadoPinPad_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtemDadoPinPad_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_obtemDadoPinPad_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_obtemDadoPinPad_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ObtemDadoPinPad_Ljava_lang_String_Ljava_lang_String_);
			return cb_obtemDadoPinPad_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ObtemDadoPinPad_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemDadoPinPad (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadoPinPad' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("obtemDadoPinPad", "(Ljava/lang/String;Ljava/lang/String;)I", "GetObtemDadoPinPad_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ObtemDadoPinPad (string p0, string p1)
		{
			const string __id = "obtemDadoPinPad.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_obtemDadoPinPadDireto;
#pragma warning disable 0169
		static Delegate GetObtemDadoPinPadDiretoHandler ()
		{
			if (cb_obtemDadoPinPadDireto == null)
				cb_obtemDadoPinPadDireto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemDadoPinPadDireto);
			return cb_obtemDadoPinPadDireto;
		}

		static int n_ObtemDadoPinPadDireto (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemDadoPinPadDireto ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadoPinPadDireto' and count(parameter)=0]"
		[Register ("obtemDadoPinPadDireto", "()I", "GetObtemDadoPinPadDiretoHandler")]
		public virtual unsafe int ObtemDadoPinPadDireto ()
		{
			const string __id = "obtemDadoPinPadDireto.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemDadoPinPadDireto_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtemDadoPinPadDireto_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_obtemDadoPinPadDireto_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_obtemDadoPinPadDireto_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ObtemDadoPinPadDireto_Ljava_lang_String_Ljava_lang_String_);
			return cb_obtemDadoPinPadDireto_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ObtemDadoPinPadDireto_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemDadoPinPadDireto (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadoPinPadDireto' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("obtemDadoPinPadDireto", "(Ljava/lang/String;Ljava/lang/String;)I", "GetObtemDadoPinPadDireto_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ObtemDadoPinPadDireto (string p0, string p1)
		{
			const string __id = "obtemDadoPinPadDireto.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_obtemDadoPinPadDiretoEx;
#pragma warning disable 0169
		static Delegate GetObtemDadoPinPadDiretoExHandler ()
		{
			if (cb_obtemDadoPinPadDiretoEx == null)
				cb_obtemDadoPinPadDiretoEx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemDadoPinPadDiretoEx);
			return cb_obtemDadoPinPadDiretoEx;
		}

		static int n_ObtemDadoPinPadDiretoEx (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemDadoPinPadDiretoEx ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadoPinPadDiretoEx' and count(parameter)=0]"
		[Register ("obtemDadoPinPadDiretoEx", "()I", "GetObtemDadoPinPadDiretoExHandler")]
		public virtual unsafe int ObtemDadoPinPadDiretoEx ()
		{
			const string __id = "obtemDadoPinPadDiretoEx.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemDadoPinPadDiretoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtemDadoPinPadDiretoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_obtemDadoPinPadDiretoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_obtemDadoPinPadDiretoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ObtemDadoPinPadDiretoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_obtemDadoPinPadDiretoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ObtemDadoPinPadDiretoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemDadoPinPadDiretoEx (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadoPinPadDiretoEx' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("obtemDadoPinPadDiretoEx", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetObtemDadoPinPadDiretoEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ObtemDadoPinPadDiretoEx (string p0, string p1, string p2)
		{
			const string __id = "obtemDadoPinPadDiretoEx.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_obtemDadoPinPadEx;
#pragma warning disable 0169
		static Delegate GetObtemDadoPinPadExHandler ()
		{
			if (cb_obtemDadoPinPadEx == null)
				cb_obtemDadoPinPadEx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemDadoPinPadEx);
			return cb_obtemDadoPinPadEx;
		}

		static int n_ObtemDadoPinPadEx (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemDadoPinPadEx ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadoPinPadEx' and count(parameter)=0]"
		[Register ("obtemDadoPinPadEx", "()I", "GetObtemDadoPinPadExHandler")]
		public virtual unsafe int ObtemDadoPinPadEx ()
		{
			const string __id = "obtemDadoPinPadEx.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemDadoPinPadEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtemDadoPinPadEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_obtemDadoPinPadEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_obtemDadoPinPadEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ObtemDadoPinPadEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_obtemDadoPinPadEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ObtemDadoPinPadEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemDadoPinPadEx (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadoPinPadEx' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("obtemDadoPinPadEx", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetObtemDadoPinPadEx_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ObtemDadoPinPadEx (string p0, string p1, string p2)
		{
			const string __id = "obtemDadoPinPadEx.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_obtemDadosCriptografados;
#pragma warning disable 0169
		static Delegate GetObtemDadosCriptografadosHandler ()
		{
			if (cb_obtemDadosCriptografados == null)
				cb_obtemDadosCriptografados = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemDadosCriptografados);
			return cb_obtemDadosCriptografados;
		}

		static int n_ObtemDadosCriptografados (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemDadosCriptografados ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadosCriptografados' and count(parameter)=0]"
		[Register ("obtemDadosCriptografados", "()I", "GetObtemDadosCriptografadosHandler")]
		public virtual unsafe int ObtemDadosCriptografados ()
		{
			const string __id = "obtemDadosCriptografados.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemDadosCriptografados_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtemDadosCriptografados_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_obtemDadosCriptografados_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_obtemDadosCriptografados_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_ObtemDadosCriptografados_Ljava_lang_String_ILjava_lang_String_);
			return cb_obtemDadosCriptografados_Ljava_lang_String_ILjava_lang_String_;
		}

		static int n_ObtemDadosCriptografados_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemDadosCriptografados (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemDadosCriptografados' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("obtemDadosCriptografados", "(Ljava/lang/String;ILjava/lang/String;)I", "GetObtemDadosCriptografados_Ljava_lang_String_ILjava_lang_String_Handler")]
		public virtual unsafe int ObtemDadosCriptografados (string p0, int p1, string p2)
		{
			const string __id = "obtemDadosCriptografados.(Ljava/lang/String;ILjava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_obtemInformacoesPinPad;
#pragma warning disable 0169
		static Delegate GetObtemInformacoesPinPadHandler ()
		{
			if (cb_obtemInformacoesPinPad == null)
				cb_obtemInformacoesPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemInformacoesPinPad);
			return cb_obtemInformacoesPinPad;
		}

		static int n_ObtemInformacoesPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemInformacoesPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemInformacoesPinPad' and count(parameter)=0]"
		[Register ("obtemInformacoesPinPad", "()I", "GetObtemInformacoesPinPadHandler")]
		public virtual unsafe int ObtemInformacoesPinPad ()
		{
			const string __id = "obtemInformacoesPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemParametrosSiTef;
#pragma warning disable 0169
		static Delegate GetObtemParametrosSiTefHandler ()
		{
			if (cb_obtemParametrosSiTef == null)
				cb_obtemParametrosSiTef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemParametrosSiTef);
			return cb_obtemParametrosSiTef;
		}

		static int n_ObtemParametrosSiTef (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemParametrosSiTef ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemParametrosSiTef' and count(parameter)=0]"
		[Register ("obtemParametrosSiTef", "()I", "GetObtemParametrosSiTefHandler")]
		public virtual unsafe int ObtemParametrosSiTef ()
		{
			const string __id = "obtemParametrosSiTef.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemParametrosSiTef_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtemParametrosSiTef_ILjava_lang_String_Handler ()
		{
			if (cb_obtemParametrosSiTef_ILjava_lang_String_ == null)
				cb_obtemParametrosSiTef_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_ObtemParametrosSiTef_ILjava_lang_String_);
			return cb_obtemParametrosSiTef_ILjava_lang_String_;
		}

		static int n_ObtemParametrosSiTef_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemParametrosSiTef (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemParametrosSiTef' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("obtemParametrosSiTef", "(ILjava/lang/String;)I", "GetObtemParametrosSiTef_ILjava_lang_String_Handler")]
		public virtual unsafe int ObtemParametrosSiTef (int p0, string p1)
		{
			const string __id = "obtemParametrosSiTef.(ILjava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_obtemQuantidadeTransacoesPendentes;
#pragma warning disable 0169
		static Delegate GetObtemQuantidadeTransacoesPendentesHandler ()
		{
			if (cb_obtemQuantidadeTransacoesPendentes == null)
				cb_obtemQuantidadeTransacoesPendentes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemQuantidadeTransacoesPendentes);
			return cb_obtemQuantidadeTransacoesPendentes;
		}

		static int n_ObtemQuantidadeTransacoesPendentes (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemQuantidadeTransacoesPendentes ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemQuantidadeTransacoesPendentes' and count(parameter)=0]"
		[Register ("obtemQuantidadeTransacoesPendentes", "()I", "GetObtemQuantidadeTransacoesPendentesHandler")]
		public virtual unsafe int ObtemQuantidadeTransacoesPendentes ()
		{
			const string __id = "obtemQuantidadeTransacoesPendentes.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemQuantidadeTransacoesPendentes_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtemQuantidadeTransacoesPendentes_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_obtemQuantidadeTransacoesPendentes_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_obtemQuantidadeTransacoesPendentes_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ObtemQuantidadeTransacoesPendentes_Ljava_lang_String_Ljava_lang_String_);
			return cb_obtemQuantidadeTransacoesPendentes_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ObtemQuantidadeTransacoesPendentes_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemQuantidadeTransacoesPendentes (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemQuantidadeTransacoesPendentes' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("obtemQuantidadeTransacoesPendentes", "(Ljava/lang/String;Ljava/lang/String;)I", "GetObtemQuantidadeTransacoesPendentes_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ObtemQuantidadeTransacoesPendentes (string p0, string p1)
		{
			const string __id = "obtemQuantidadeTransacoesPendentes.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_obtemRetornoEnviaRecebeSiTefDireto;
#pragma warning disable 0169
		static Delegate GetObtemRetornoEnviaRecebeSiTefDiretoHandler ()
		{
			if (cb_obtemRetornoEnviaRecebeSiTefDireto == null)
				cb_obtemRetornoEnviaRecebeSiTefDireto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemRetornoEnviaRecebeSiTefDireto);
			return cb_obtemRetornoEnviaRecebeSiTefDireto;
		}

		static int n_ObtemRetornoEnviaRecebeSiTefDireto (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemRetornoEnviaRecebeSiTefDireto ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemRetornoEnviaRecebeSiTefDireto' and count(parameter)=0]"
		[Register ("obtemRetornoEnviaRecebeSiTefDireto", "()I", "GetObtemRetornoEnviaRecebeSiTefDiretoHandler")]
		public virtual unsafe int ObtemRetornoEnviaRecebeSiTefDireto ()
		{
			const string __id = "obtemRetornoEnviaRecebeSiTefDireto.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemRetornoEnviaRecebeSiTefDireto_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetObtemRetornoEnviaRecebeSiTefDireto_Ljava_lang_String_SHandler ()
		{
			if (cb_obtemRetornoEnviaRecebeSiTefDireto_Ljava_lang_String_S == null)
				cb_obtemRetornoEnviaRecebeSiTefDireto_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, short, int>) n_ObtemRetornoEnviaRecebeSiTefDireto_Ljava_lang_String_S);
			return cb_obtemRetornoEnviaRecebeSiTefDireto_Ljava_lang_String_S;
		}

		static int n_ObtemRetornoEnviaRecebeSiTefDireto_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemRetornoEnviaRecebeSiTefDireto (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemRetornoEnviaRecebeSiTefDireto' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short']]"
		[Register ("obtemRetornoEnviaRecebeSiTefDireto", "(Ljava/lang/String;S)I", "GetObtemRetornoEnviaRecebeSiTefDireto_Ljava_lang_String_SHandler")]
		public virtual unsafe int ObtemRetornoEnviaRecebeSiTefDireto (string p0, short p1)
		{
			const string __id = "obtemRetornoEnviaRecebeSiTefDireto.(Ljava/lang/String;S)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_obtemSenha;
#pragma warning disable 0169
		static Delegate GetObtemSenhaHandler ()
		{
			if (cb_obtemSenha == null)
				cb_obtemSenha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemSenha);
			return cb_obtemSenha;
		}

		static int n_ObtemSenha (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemSenha ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemSenha' and count(parameter)=0]"
		[Register ("obtemSenha", "()I", "GetObtemSenhaHandler")]
		public virtual unsafe int ObtemSenha ()
		{
			const string __id = "obtemSenha.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemSenha_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtemSenha_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_obtemSenha_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_obtemSenha_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ObtemSenha_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_obtemSenha_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ObtemSenha_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ObtemSenha (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemSenha' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("obtemSenha", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetObtemSenha_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int ObtemSenha (string p0, string p1, string p2)
		{
			const string __id = "obtemSenha.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_obtemStatusLeitoraSPTrans;
#pragma warning disable 0169
		static Delegate GetObtemStatusLeitoraSPTransHandler ()
		{
			if (cb_obtemStatusLeitoraSPTrans == null)
				cb_obtemStatusLeitoraSPTrans = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemStatusLeitoraSPTrans);
			return cb_obtemStatusLeitoraSPTrans;
		}

		static int n_ObtemStatusLeitoraSPTrans (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemStatusLeitoraSPTrans ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemStatusLeitoraSPTrans' and count(parameter)=0]"
		[Register ("obtemStatusLeitoraSPTrans", "()I", "GetObtemStatusLeitoraSPTransHandler")]
		public virtual unsafe int ObtemStatusLeitoraSPTrans ()
		{
			const string __id = "obtemStatusLeitoraSPTrans.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_obtemVersao;
#pragma warning disable 0169
		static Delegate GetObtemVersaoHandler ()
		{
			if (cb_obtemVersao == null)
				cb_obtemVersao = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObtemVersao);
			return cb_obtemVersao;
		}

		static int n_ObtemVersao (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemVersao ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='obtemVersao' and count(parameter)=0]"
		[Register ("obtemVersao", "()I", "GetObtemVersaoHandler")]
		public virtual unsafe int ObtemVersao ()
		{
			const string __id = "obtemVersao.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pinPadBTExecuta_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPinPadBTExecuta_ILjava_lang_String_Handler ()
		{
			if (cb_pinPadBTExecuta_ILjava_lang_String_ == null)
				cb_pinPadBTExecuta_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_PinPadBTExecuta_ILjava_lang_String_);
			return cb_pinPadBTExecuta_ILjava_lang_String_;
		}

		static int n_PinPadBTExecuta_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PinPadBTExecuta (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='pinPadBTExecuta' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("pinPadBTExecuta", "(ILjava/lang/String;)I", "GetPinPadBTExecuta_ILjava_lang_String_Handler")]
		public virtual unsafe int PinPadBTExecuta (int p0, string p1)
		{
			const string __id = "pinPadBTExecuta.(ILjava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_pinPadInterativo_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPinPadInterativo_ILjava_lang_String_Handler ()
		{
			if (cb_pinPadInterativo_ILjava_lang_String_ == null)
				cb_pinPadInterativo_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_PinPadInterativo_ILjava_lang_String_);
			return cb_pinPadInterativo_ILjava_lang_String_;
		}

		static int n_PinPadInterativo_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PinPadInterativo (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='pinPadInterativo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("pinPadInterativo", "(ILjava/lang/String;)I", "GetPinPadInterativo_ILjava_lang_String_Handler")]
		public virtual unsafe int PinPadInterativo (int p0, string p1)
		{
			const string __id = "pinPadInterativo.(ILjava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_registraBonusOffLineSiTef;
#pragma warning disable 0169
		static Delegate GetRegistraBonusOffLineSiTefHandler ()
		{
			if (cb_registraBonusOffLineSiTef == null)
				cb_registraBonusOffLineSiTef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RegistraBonusOffLineSiTef);
			return cb_registraBonusOffLineSiTef;
		}

		static int n_RegistraBonusOffLineSiTef (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegistraBonusOffLineSiTef ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='registraBonusOffLineSiTef' and count(parameter)=0]"
		[Register ("registraBonusOffLineSiTef", "()I", "GetRegistraBonusOffLineSiTefHandler")]
		public virtual unsafe int RegistraBonusOffLineSiTef ()
		{
			const string __id = "registraBonusOffLineSiTef.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_registraBonusOffLineSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegistraBonusOffLineSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registraBonusOffLineSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registraBonusOffLineSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_RegistraBonusOffLineSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_registraBonusOffLineSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_RegistraBonusOffLineSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RegistraBonusOffLineSiTef (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='registraBonusOffLineSiTef' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("registraBonusOffLineSiTef", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetRegistraBonusOffLineSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int RegistraBonusOffLineSiTef (string p0, string p1, string p2, string p3, string p4, string p5, string p6)
		{
			const string __id = "registraBonusOffLineSiTef.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_registraDescontoSocioTorcedor;
#pragma warning disable 0169
		static Delegate GetRegistraDescontoSocioTorcedorHandler ()
		{
			if (cb_registraDescontoSocioTorcedor == null)
				cb_registraDescontoSocioTorcedor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RegistraDescontoSocioTorcedor);
			return cb_registraDescontoSocioTorcedor;
		}

		static int n_RegistraDescontoSocioTorcedor (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegistraDescontoSocioTorcedor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='registraDescontoSocioTorcedor' and count(parameter)=0]"
		[Register ("registraDescontoSocioTorcedor", "()I", "GetRegistraDescontoSocioTorcedorHandler")]
		public virtual unsafe int RegistraDescontoSocioTorcedor ()
		{
			const string __id = "registraDescontoSocioTorcedor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_registraDescontoSocioTorcedor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegistraDescontoSocioTorcedor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registraDescontoSocioTorcedor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registraDescontoSocioTorcedor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_RegistraDescontoSocioTorcedor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_registraDescontoSocioTorcedor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_RegistraDescontoSocioTorcedor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RegistraDescontoSocioTorcedor (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='registraDescontoSocioTorcedor' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("registraDescontoSocioTorcedor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetRegistraDescontoSocioTorcedor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int RegistraDescontoSocioTorcedor (string p0, string p1, string p2, string p3, string p4, string p5)
		{
			const string __id = "registraDescontoSocioTorcedor.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_registraDescontoSocioTorcedorSequencial;
#pragma warning disable 0169
		static Delegate GetRegistraDescontoSocioTorcedorSequencialHandler ()
		{
			if (cb_registraDescontoSocioTorcedorSequencial == null)
				cb_registraDescontoSocioTorcedorSequencial = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RegistraDescontoSocioTorcedorSequencial);
			return cb_registraDescontoSocioTorcedorSequencial;
		}

		static int n_RegistraDescontoSocioTorcedorSequencial (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegistraDescontoSocioTorcedorSequencial ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='registraDescontoSocioTorcedorSequencial' and count(parameter)=0]"
		[Register ("registraDescontoSocioTorcedorSequencial", "()I", "GetRegistraDescontoSocioTorcedorSequencialHandler")]
		public virtual unsafe int RegistraDescontoSocioTorcedorSequencial ()
		{
			const string __id = "registraDescontoSocioTorcedorSequencial.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_registraDescontoSocioTorcedorSequencial_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetRegistraDescontoSocioTorcedorSequencial_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_registraDescontoSocioTorcedorSequencial_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_registraDescontoSocioTorcedorSequencial_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_RegistraDescontoSocioTorcedorSequencial_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I);
			return cb_registraDescontoSocioTorcedorSequencial_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		}

		static int n_RegistraDescontoSocioTorcedorSequencial_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, int p6)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RegistraDescontoSocioTorcedorSequencial (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='registraDescontoSocioTorcedorSequencial' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int']]"
		[Register ("registraDescontoSocioTorcedorSequencial", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)I", "GetRegistraDescontoSocioTorcedorSequencial_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe int RegistraDescontoSocioTorcedorSequencial (string p0, string p1, string p2, string p3, string p4, string p5, int p6)
		{
			const string __id = "registraDescontoSocioTorcedorSequencial.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (p6);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_registraTefPromocaoSiTef;
#pragma warning disable 0169
		static Delegate GetRegistraTefPromocaoSiTefHandler ()
		{
			if (cb_registraTefPromocaoSiTef == null)
				cb_registraTefPromocaoSiTef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RegistraTefPromocaoSiTef);
			return cb_registraTefPromocaoSiTef;
		}

		static int n_RegistraTefPromocaoSiTef (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegistraTefPromocaoSiTef ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='registraTefPromocaoSiTef' and count(parameter)=0]"
		[Register ("registraTefPromocaoSiTef", "()I", "GetRegistraTefPromocaoSiTefHandler")]
		public virtual unsafe int RegistraTefPromocaoSiTef ()
		{
			const string __id = "registraTefPromocaoSiTef.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_registraTefPromocaoSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegistraTefPromocaoSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registraTefPromocaoSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registraTefPromocaoSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_RegistraTefPromocaoSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_registraTefPromocaoSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_RegistraTefPromocaoSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RegistraTefPromocaoSiTef (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='registraTefPromocaoSiTef' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("registraTefPromocaoSiTef", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetRegistraTefPromocaoSiTef_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int RegistraTefPromocaoSiTef (string p0, string p1, string p2, string p3, string p4, string p5, string p6)
		{
			const string __id = "registraTefPromocaoSiTef.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_setArqTraducao_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetArqTraducao_Ljava_lang_String_Handler ()
		{
			if (cb_setArqTraducao_Ljava_lang_String_ == null)
				cb_setArqTraducao_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetArqTraducao_Ljava_lang_String_);
			return cb_setArqTraducao_Ljava_lang_String_;
		}

		static void n_SetArqTraducao_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetArqTraducao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setArqTraducao' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setArqTraducao", "(Ljava/lang/String;)V", "GetSetArqTraducao_Ljava_lang_String_Handler")]
		public virtual unsafe void SetArqTraducao (string p0)
		{
			const string __id = "setArqTraducao.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setArqTraducaoCielo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetArqTraducaoCielo_Ljava_lang_String_Handler ()
		{
			if (cb_setArqTraducaoCielo_Ljava_lang_String_ == null)
				cb_setArqTraducaoCielo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetArqTraducaoCielo_Ljava_lang_String_);
			return cb_setArqTraducaoCielo_Ljava_lang_String_;
		}

		static void n_SetArqTraducaoCielo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetArqTraducaoCielo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setArqTraducaoCielo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setArqTraducaoCielo", "(Ljava/lang/String;)V", "GetSetArqTraducaoCielo_Ljava_lang_String_Handler")]
		public virtual unsafe void SetArqTraducaoCielo (string p0)
		{
			const string __id = "setArqTraducaoCielo.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setChaveAcesso_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveAcesso_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveAcesso_Ljava_lang_String_ == null)
				cb_setChaveAcesso_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChaveAcesso_Ljava_lang_String_);
			return cb_setChaveAcesso_Ljava_lang_String_;
		}

		static void n_SetChaveAcesso_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChaveAcesso (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setChaveAcesso' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChaveAcesso", "(Ljava/lang/String;)V", "GetSetChaveAcesso_Ljava_lang_String_Handler")]
		public virtual unsafe void SetChaveAcesso (string p0)
		{
			const string __id = "setChaveAcesso.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setChaveSecreta_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveSecreta_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveSecreta_Ljava_lang_String_ == null)
				cb_setChaveSecreta_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChaveSecreta_Ljava_lang_String_);
			return cb_setChaveSecreta_Ljava_lang_String_;
		}

		static void n_SetChaveSecreta_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChaveSecreta (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setChaveSecreta' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChaveSecreta", "(Ljava/lang/String;)V", "GetSetChaveSecreta_Ljava_lang_String_Handler")]
		public virtual unsafe void SetChaveSecreta (string p0)
		{
			const string __id = "setChaveSecreta.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setChaveTrnCancelamento_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveTrnCancelamento_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveTrnCancelamento_Ljava_lang_String_ == null)
				cb_setChaveTrnCancelamento_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChaveTrnCancelamento_Ljava_lang_String_);
			return cb_setChaveTrnCancelamento_Ljava_lang_String_;
		}

		static void n_SetChaveTrnCancelamento_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChaveTrnCancelamento (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setChaveTrnCancelamento' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChaveTrnCancelamento", "(Ljava/lang/String;)V", "GetSetChaveTrnCancelamento_Ljava_lang_String_Handler")]
		public virtual unsafe void SetChaveTrnCancelamento (string p0)
		{
			const string __id = "setChaveTrnCancelamento.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCodigoAutorizacao_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCodigoAutorizacao_Ljava_lang_String_Handler ()
		{
			if (cb_setCodigoAutorizacao_Ljava_lang_String_ == null)
				cb_setCodigoAutorizacao_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCodigoAutorizacao_Ljava_lang_String_);
			return cb_setCodigoAutorizacao_Ljava_lang_String_;
		}

		static void n_SetCodigoAutorizacao_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCodigoAutorizacao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setCodigoAutorizacao' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCodigoAutorizacao", "(Ljava/lang/String;)V", "GetSetCodigoAutorizacao_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCodigoAutorizacao (string p0)
		{
			const string __id = "setCodigoAutorizacao.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCodigoEmBarras_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCodigoEmBarras_Ljava_lang_String_Handler ()
		{
			if (cb_setCodigoEmBarras_Ljava_lang_String_ == null)
				cb_setCodigoEmBarras_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCodigoEmBarras_Ljava_lang_String_);
			return cb_setCodigoEmBarras_Ljava_lang_String_;
		}

		static void n_SetCodigoEmBarras_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCodigoEmBarras (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setCodigoEmBarras' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCodigoEmBarras", "(Ljava/lang/String;)V", "GetSetCodigoEmBarras_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCodigoEmBarras (string p0)
		{
			const string __id = "setCodigoEmBarras.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCodigoLoja_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCodigoLoja_Ljava_lang_String_Handler ()
		{
			if (cb_setCodigoLoja_Ljava_lang_String_ == null)
				cb_setCodigoLoja_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCodigoLoja_Ljava_lang_String_);
			return cb_setCodigoLoja_Ljava_lang_String_;
		}

		static void n_SetCodigoLoja_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCodigoLoja (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setCodigoLoja' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCodigoLoja", "(Ljava/lang/String;)V", "GetSetCodigoLoja_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCodigoLoja (string p0)
		{
			const string __id = "setCodigoLoja.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCodigoProduto_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCodigoProduto_Ljava_lang_String_Handler ()
		{
			if (cb_setCodigoProduto_Ljava_lang_String_ == null)
				cb_setCodigoProduto_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCodigoProduto_Ljava_lang_String_);
			return cb_setCodigoProduto_Ljava_lang_String_;
		}

		static void n_SetCodigoProduto_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCodigoProduto (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setCodigoProduto' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCodigoProduto", "(Ljava/lang/String;)V", "GetSetCodigoProduto_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCodigoProduto (string p0)
		{
			const string __id = "setCodigoProduto.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCodigoServico_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCodigoServico_Ljava_lang_String_Handler ()
		{
			if (cb_setCodigoServico_Ljava_lang_String_ == null)
				cb_setCodigoServico_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCodigoServico_Ljava_lang_String_);
			return cb_setCodigoServico_Ljava_lang_String_;
		}

		static void n_SetCodigoServico_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCodigoServico (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setCodigoServico' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCodigoServico", "(Ljava/lang/String;)V", "GetSetCodigoServico_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCodigoServico (string p0)
		{
			const string __id = "setCodigoServico.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setConfiguraResultado_I;
#pragma warning disable 0169
		static Delegate GetSetConfiguraResultado_IHandler ()
		{
			if (cb_setConfiguraResultado_I == null)
				cb_setConfiguraResultado_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConfiguraResultado_I);
			return cb_setConfiguraResultado_I;
		}

		static void n_SetConfiguraResultado_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConfiguraResultado (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setConfiguraResultado' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConfiguraResultado", "(I)V", "GetSetConfiguraResultado_IHandler")]
		public virtual unsafe void SetConfiguraResultado (int p0)
		{
			const string __id = "setConfiguraResultado.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setConfiguraResultado_S;
#pragma warning disable 0169
		static Delegate GetSetConfiguraResultado_SHandler ()
		{
			if (cb_setConfiguraResultado_S == null)
				cb_setConfiguraResultado_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetConfiguraResultado_S);
			return cb_setConfiguraResultado_S;
		}

		static void n_SetConfiguraResultado_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConfiguraResultado (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setConfiguraResultado' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setConfiguraResultado", "(S)V", "GetSetConfiguraResultado_SHandler")]
		public virtual unsafe void SetConfiguraResultado (short p0)
		{
			const string __id = "setConfiguraResultado.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setConfirma_I;
#pragma warning disable 0169
		static Delegate GetSetConfirma_IHandler ()
		{
			if (cb_setConfirma_I == null)
				cb_setConfirma_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConfirma_I);
			return cb_setConfirma_I;
		}

		static void n_SetConfirma_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConfirma (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setConfirma' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConfirma", "(I)V", "GetSetConfirma_IHandler")]
		public virtual unsafe void SetConfirma (int p0)
		{
			const string __id = "setConfirma.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setConfirma_S;
#pragma warning disable 0169
		static Delegate GetSetConfirma_SHandler ()
		{
			if (cb_setConfirma_S == null)
				cb_setConfirma_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetConfirma_S);
			return cb_setConfirma_S;
		}

		static void n_SetConfirma_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConfirma (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setConfirma' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setConfirma", "(S)V", "GetSetConfirma_SHandler")]
		public virtual unsafe void SetConfirma (short p0)
		{
			const string __id = "setConfirma.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setContinuaNavegacao_I;
#pragma warning disable 0169
		static Delegate GetSetContinuaNavegacao_IHandler ()
		{
			if (cb_setContinuaNavegacao_I == null)
				cb_setContinuaNavegacao_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetContinuaNavegacao_I);
			return cb_setContinuaNavegacao_I;
		}

		static void n_SetContinuaNavegacao_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContinuaNavegacao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setContinuaNavegacao' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContinuaNavegacao", "(I)V", "GetSetContinuaNavegacao_IHandler")]
		public virtual unsafe void SetContinuaNavegacao (int p0)
		{
			const string __id = "setContinuaNavegacao.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDadosCaptura_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDadosCaptura_Ljava_lang_String_Handler ()
		{
			if (cb_setDadosCaptura_Ljava_lang_String_ == null)
				cb_setDadosCaptura_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDadosCaptura_Ljava_lang_String_);
			return cb_setDadosCaptura_Ljava_lang_String_;
		}

		static void n_SetDadosCaptura_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDadosCaptura (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDadosCaptura' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDadosCaptura", "(Ljava/lang/String;)V", "GetSetDadosCaptura_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDadosCaptura (string p0)
		{
			const string __id = "setDadosCaptura.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDadosEntrada_arrayB;
#pragma warning disable 0169
		static Delegate GetSetDadosEntrada_arrayBHandler ()
		{
			if (cb_setDadosEntrada_arrayB == null)
				cb_setDadosEntrada_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDadosEntrada_arrayB);
			return cb_setDadosEntrada_arrayB;
		}

		static void n_SetDadosEntrada_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetDadosEntrada (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDadosEntrada' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setDadosEntrada", "([B)V", "GetSetDadosEntrada_arrayBHandler")]
		public virtual unsafe void SetDadosEntrada (byte[] p0)
		{
			const string __id = "setDadosEntrada.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setDadosTransacao_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDadosTransacao_Ljava_lang_String_Handler ()
		{
			if (cb_setDadosTransacao_Ljava_lang_String_ == null)
				cb_setDadosTransacao_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDadosTransacao_Ljava_lang_String_);
			return cb_setDadosTransacao_Ljava_lang_String_;
		}

		static void n_SetDadosTransacao_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDadosTransacao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDadosTransacao' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDadosTransacao", "(Ljava/lang/String;)V", "GetSetDadosTransacao_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDadosTransacao (string p0)
		{
			const string __id = "setDadosTransacao.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDadosTx_arrayB;
#pragma warning disable 0169
		static Delegate GetSetDadosTx_arrayBHandler ()
		{
			if (cb_setDadosTx_arrayB == null)
				cb_setDadosTx_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDadosTx_arrayB);
			return cb_setDadosTx_arrayB;
		}

		static void n_SetDadosTx_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetDadosTx (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDadosTx' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setDadosTx", "([B)V", "GetSetDadosTx_arrayBHandler")]
		public virtual unsafe void SetDadosTx (byte[] p0)
		{
			const string __id = "setDadosTx.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setDataFiscal_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDataFiscal_Ljava_lang_String_Handler ()
		{
			if (cb_setDataFiscal_Ljava_lang_String_ == null)
				cb_setDataFiscal_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataFiscal_Ljava_lang_String_);
			return cb_setDataFiscal_Ljava_lang_String_;
		}

		static void n_SetDataFiscal_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataFiscal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDataFiscal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDataFiscal", "(Ljava/lang/String;)V", "GetSetDataFiscal_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDataFiscal (string p0)
		{
			const string __id = "setDataFiscal.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDataFiscalOriginal_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDataFiscalOriginal_Ljava_lang_String_Handler ()
		{
			if (cb_setDataFiscalOriginal_Ljava_lang_String_ == null)
				cb_setDataFiscalOriginal_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataFiscalOriginal_Ljava_lang_String_);
			return cb_setDataFiscalOriginal_Ljava_lang_String_;
		}

		static void n_SetDataFiscalOriginal_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataFiscalOriginal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDataFiscalOriginal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDataFiscalOriginal", "(Ljava/lang/String;)V", "GetSetDataFiscalOriginal_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDataFiscalOriginal (string p0)
		{
			const string __id = "setDataFiscalOriginal.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDelimitador_I;
#pragma warning disable 0169
		static Delegate GetSetDelimitador_IHandler ()
		{
			if (cb_setDelimitador_I == null)
				cb_setDelimitador_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDelimitador_I);
			return cb_setDelimitador_I;
		}

		static void n_SetDelimitador_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDelimitador (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDelimitador' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDelimitador", "(I)V", "GetSetDelimitador_IHandler")]
		public virtual unsafe void SetDelimitador (int p0)
		{
			const string __id = "setDelimitador.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDelimitador_S;
#pragma warning disable 0169
		static Delegate GetSetDelimitador_SHandler ()
		{
			if (cb_setDelimitador_S == null)
				cb_setDelimitador_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetDelimitador_S);
			return cb_setDelimitador_S;
		}

		static void n_SetDelimitador_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDelimitador (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setDelimitador' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setDelimitador", "(S)V", "GetSetDelimitador_SHandler")]
		public virtual unsafe void SetDelimitador (short p0)
		{
			const string __id = "setDelimitador.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEnderecoSiTef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEnderecoSiTef_Ljava_lang_String_Handler ()
		{
			if (cb_setEnderecoSiTef_Ljava_lang_String_ == null)
				cb_setEnderecoSiTef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEnderecoSiTef_Ljava_lang_String_);
			return cb_setEnderecoSiTef_Ljava_lang_String_;
		}

		static void n_SetEnderecoSiTef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEnderecoSiTef (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setEnderecoSiTef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEnderecoSiTef", "(Ljava/lang/String;)V", "GetSetEnderecoSiTef_Ljava_lang_String_Handler")]
		public virtual unsafe void SetEnderecoSiTef (string p0)
		{
			const string __id = "setEnderecoSiTef.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFuncaoSiTef_I;
#pragma warning disable 0169
		static Delegate GetSetFuncaoSiTef_IHandler ()
		{
			if (cb_setFuncaoSiTef_I == null)
				cb_setFuncaoSiTef_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFuncaoSiTef_I);
			return cb_setFuncaoSiTef_I;
		}

		static void n_SetFuncaoSiTef_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFuncaoSiTef (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setFuncaoSiTef' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFuncaoSiTef", "(I)V", "GetSetFuncaoSiTef_IHandler")]
		public virtual unsafe void SetFuncaoSiTef (int p0)
		{
			const string __id = "setFuncaoSiTef.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFuncaoSiTef_S;
#pragma warning disable 0169
		static Delegate GetSetFuncaoSiTef_SHandler ()
		{
			if (cb_setFuncaoSiTef_S == null)
				cb_setFuncaoSiTef_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetFuncaoSiTef_S);
			return cb_setFuncaoSiTef_S;
		}

		static void n_SetFuncaoSiTef_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFuncaoSiTef (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setFuncaoSiTef' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setFuncaoSiTef", "(S)V", "GetSetFuncaoSiTef_SHandler")]
		public virtual unsafe void SetFuncaoSiTef (short p0)
		{
			const string __id = "setFuncaoSiTef.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHorario_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHorario_Ljava_lang_String_Handler ()
		{
			if (cb_setHorario_Ljava_lang_String_ == null)
				cb_setHorario_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHorario_Ljava_lang_String_);
			return cb_setHorario_Ljava_lang_String_;
		}

		static void n_SetHorario_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHorario (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setHorario' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHorario", "(Ljava/lang/String;)V", "GetSetHorario_Ljava_lang_String_Handler")]
		public virtual unsafe void SetHorario (string p0)
		{
			const string __id = "setHorario.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setIdentificacaoPdvOriginal_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIdentificacaoPdvOriginal_Ljava_lang_String_Handler ()
		{
			if (cb_setIdentificacaoPdvOriginal_Ljava_lang_String_ == null)
				cb_setIdentificacaoPdvOriginal_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIdentificacaoPdvOriginal_Ljava_lang_String_);
			return cb_setIdentificacaoPdvOriginal_Ljava_lang_String_;
		}

		static void n_SetIdentificacaoPdvOriginal_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIdentificacaoPdvOriginal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setIdentificacaoPdvOriginal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setIdentificacaoPdvOriginal", "(Ljava/lang/String;)V", "GetSetIdentificacaoPdvOriginal_Ljava_lang_String_Handler")]
		public virtual unsafe void SetIdentificacaoPdvOriginal (string p0)
		{
			const string __id = "setIdentificacaoPdvOriginal.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setIndiceParametro_I;
#pragma warning disable 0169
		static Delegate GetSetIndiceParametro_IHandler ()
		{
			if (cb_setIndiceParametro_I == null)
				cb_setIndiceParametro_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndiceParametro_I);
			return cb_setIndiceParametro_I;
		}

		static void n_SetIndiceParametro_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndiceParametro (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setIndiceParametro' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIndiceParametro", "(I)V", "GetSetIndiceParametro_IHandler")]
		public virtual unsafe void SetIndiceParametro (int p0)
		{
			const string __id = "setIndiceParametro.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIndiceParametro_S;
#pragma warning disable 0169
		static Delegate GetSetIndiceParametro_SHandler ()
		{
			if (cb_setIndiceParametro_S == null)
				cb_setIndiceParametro_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetIndiceParametro_S);
			return cb_setIndiceParametro_S;
		}

		static void n_SetIndiceParametro_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndiceParametro (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setIndiceParametro' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setIndiceParametro", "(S)V", "GetSetIndiceParametro_SHandler")]
		public virtual unsafe void SetIndiceParametro (short p0)
		{
			const string __id = "setIndiceParametro.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIndiceProduto_I;
#pragma warning disable 0169
		static Delegate GetSetIndiceProduto_IHandler ()
		{
			if (cb_setIndiceProduto_I == null)
				cb_setIndiceProduto_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndiceProduto_I);
			return cb_setIndiceProduto_I;
		}

		static void n_SetIndiceProduto_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndiceProduto (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setIndiceProduto' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIndiceProduto", "(I)V", "GetSetIndiceProduto_IHandler")]
		public virtual unsafe void SetIndiceProduto (int p0)
		{
			const string __id = "setIndiceProduto.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIndiceProduto_S;
#pragma warning disable 0169
		static Delegate GetSetIndiceProduto_SHandler ()
		{
			if (cb_setIndiceProduto_S == null)
				cb_setIndiceProduto_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetIndiceProduto_S);
			return cb_setIndiceProduto_S;
		}

		static void n_SetIndiceProduto_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndiceProduto (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setIndiceProduto' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setIndiceProduto", "(S)V", "GetSetIndiceProduto_SHandler")]
		public virtual unsafe void SetIndiceProduto (short p0)
		{
			const string __id = "setIndiceProduto.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setModalidade_I;
#pragma warning disable 0169
		static Delegate GetSetModalidade_IHandler ()
		{
			if (cb_setModalidade_I == null)
				cb_setModalidade_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetModalidade_I);
			return cb_setModalidade_I;
		}

		static void n_SetModalidade_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetModalidade (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setModalidade' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setModalidade", "(I)V", "GetSetModalidade_IHandler")]
		public virtual unsafe void SetModalidade (int p0)
		{
			const string __id = "setModalidade.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMsgDisplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMsgDisplay_Ljava_lang_String_Handler ()
		{
			if (cb_setMsgDisplay_Ljava_lang_String_ == null)
				cb_setMsgDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMsgDisplay_Ljava_lang_String_);
			return cb_setMsgDisplay_Ljava_lang_String_;
		}

		static void n_SetMsgDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMsgDisplay (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setMsgDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMsgDisplay", "(Ljava/lang/String;)V", "GetSetMsgDisplay_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMsgDisplay (string p0)
		{
			const string __id = "setMsgDisplay.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNSUSiTef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNSUSiTef_Ljava_lang_String_Handler ()
		{
			if (cb_setNSUSiTef_Ljava_lang_String_ == null)
				cb_setNSUSiTef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNSUSiTef_Ljava_lang_String_);
			return cb_setNSUSiTef_Ljava_lang_String_;
		}

		static void n_SetNSUSiTef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNSUSiTef (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setNSUSiTef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNSUSiTef", "(Ljava/lang/String;)V", "GetSetNSUSiTef_Ljava_lang_String_Handler")]
		public virtual unsafe void SetNSUSiTef (string p0)
		{
			const string __id = "setNSUSiTef.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNomeArquivo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNomeArquivo_Ljava_lang_String_Handler ()
		{
			if (cb_setNomeArquivo_Ljava_lang_String_ == null)
				cb_setNomeArquivo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNomeArquivo_Ljava_lang_String_);
			return cb_setNomeArquivo_Ljava_lang_String_;
		}

		static void n_SetNomeArquivo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNomeArquivo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setNomeArquivo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNomeArquivo", "(Ljava/lang/String;)V", "GetSetNomeArquivo_Ljava_lang_String_Handler")]
		public virtual unsafe void SetNomeArquivo (string p0)
		{
			const string __id = "setNomeArquivo.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNumeroCuponFiscal_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNumeroCuponFiscal_Ljava_lang_String_Handler ()
		{
			if (cb_setNumeroCuponFiscal_Ljava_lang_String_ == null)
				cb_setNumeroCuponFiscal_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNumeroCuponFiscal_Ljava_lang_String_);
			return cb_setNumeroCuponFiscal_Ljava_lang_String_;
		}

		static void n_SetNumeroCuponFiscal_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNumeroCuponFiscal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setNumeroCuponFiscal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNumeroCuponFiscal", "(Ljava/lang/String;)V", "GetSetNumeroCuponFiscal_Ljava_lang_String_Handler")]
		public virtual unsafe void SetNumeroCuponFiscal (string p0)
		{
			const string __id = "setNumeroCuponFiscal.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNumeroCuponFiscalOriginal_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNumeroCuponFiscalOriginal_Ljava_lang_String_Handler ()
		{
			if (cb_setNumeroCuponFiscalOriginal_Ljava_lang_String_ == null)
				cb_setNumeroCuponFiscalOriginal_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNumeroCuponFiscalOriginal_Ljava_lang_String_);
			return cb_setNumeroCuponFiscalOriginal_Ljava_lang_String_;
		}

		static void n_SetNumeroCuponFiscalOriginal_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNumeroCuponFiscalOriginal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setNumeroCuponFiscalOriginal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNumeroCuponFiscalOriginal", "(Ljava/lang/String;)V", "GetSetNumeroCuponFiscalOriginal_Ljava_lang_String_Handler")]
		public virtual unsafe void SetNumeroCuponFiscalOriginal (string p0)
		{
			const string __id = "setNumeroCuponFiscalOriginal.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNumeroDocumentoOriginal_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNumeroDocumentoOriginal_Ljava_lang_String_Handler ()
		{
			if (cb_setNumeroDocumentoOriginal_Ljava_lang_String_ == null)
				cb_setNumeroDocumentoOriginal_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNumeroDocumentoOriginal_Ljava_lang_String_);
			return cb_setNumeroDocumentoOriginal_Ljava_lang_String_;
		}

		static void n_SetNumeroDocumentoOriginal_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNumeroDocumentoOriginal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setNumeroDocumentoOriginal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNumeroDocumentoOriginal", "(Ljava/lang/String;)V", "GetSetNumeroDocumentoOriginal_Ljava_lang_String_Handler")]
		public virtual unsafe void SetNumeroDocumentoOriginal (string p0)
		{
			const string __id = "setNumeroDocumentoOriginal.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNumeroProdutos_I;
#pragma warning disable 0169
		static Delegate GetSetNumeroProdutos_IHandler ()
		{
			if (cb_setNumeroProdutos_I == null)
				cb_setNumeroProdutos_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumeroProdutos_I);
			return cb_setNumeroProdutos_I;
		}

		static void n_SetNumeroProdutos_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNumeroProdutos (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setNumeroProdutos' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNumeroProdutos", "(I)V", "GetSetNumeroProdutos_IHandler")]
		public virtual unsafe void SetNumeroProdutos (int p0)
		{
			const string __id = "setNumeroProdutos.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNumeroProdutos_S;
#pragma warning disable 0169
		static Delegate GetSetNumeroProdutos_SHandler ()
		{
			if (cb_setNumeroProdutos_S == null)
				cb_setNumeroProdutos_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetNumeroProdutos_S);
			return cb_setNumeroProdutos_S;
		}

		static void n_SetNumeroProdutos_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNumeroProdutos (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setNumeroProdutos' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setNumeroProdutos", "(S)V", "GetSetNumeroProdutos_SHandler")]
		public virtual unsafe void SetNumeroProdutos (short p0)
		{
			const string __id = "setNumeroProdutos.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNumeroTerminal_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNumeroTerminal_Ljava_lang_String_Handler ()
		{
			if (cb_setNumeroTerminal_Ljava_lang_String_ == null)
				cb_setNumeroTerminal_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNumeroTerminal_Ljava_lang_String_);
			return cb_setNumeroTerminal_Ljava_lang_String_;
		}

		static void n_SetNumeroTerminal_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNumeroTerminal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setNumeroTerminal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNumeroTerminal", "(Ljava/lang/String;)V", "GetSetNumeroTerminal_Ljava_lang_String_Handler")]
		public virtual unsafe void SetNumeroTerminal (string p0)
		{
			const string __id = "setNumeroTerminal.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOffsetCartao_I;
#pragma warning disable 0169
		static Delegate GetSetOffsetCartao_IHandler ()
		{
			if (cb_setOffsetCartao_I == null)
				cb_setOffsetCartao_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOffsetCartao_I);
			return cb_setOffsetCartao_I;
		}

		static void n_SetOffsetCartao_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOffsetCartao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setOffsetCartao' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOffsetCartao", "(I)V", "GetSetOffsetCartao_IHandler")]
		public virtual unsafe void SetOffsetCartao (int p0)
		{
			const string __id = "setOffsetCartao.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOffsetCartao_S;
#pragma warning disable 0169
		static Delegate GetSetOffsetCartao_SHandler ()
		{
			if (cb_setOffsetCartao_S == null)
				cb_setOffsetCartao_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetOffsetCartao_S);
			return cb_setOffsetCartao_S;
		}

		static void n_SetOffsetCartao_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOffsetCartao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setOffsetCartao' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setOffsetCartao", "(S)V", "GetSetOffsetCartao_SHandler")]
		public virtual unsafe void SetOffsetCartao (short p0)
		{
			const string __id = "setOffsetCartao.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOperador_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOperador_Ljava_lang_String_Handler ()
		{
			if (cb_setOperador_Ljava_lang_String_ == null)
				cb_setOperador_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOperador_Ljava_lang_String_);
			return cb_setOperador_Ljava_lang_String_;
		}

		static void n_SetOperador_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOperador (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setOperador' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOperador", "(Ljava/lang/String;)V", "GetSetOperador_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOperador (string p0)
		{
			const string __id = "setOperador.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setParametro_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParametro_Ljava_lang_String_Handler ()
		{
			if (cb_setParametro_Ljava_lang_String_ == null)
				cb_setParametro_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParametro_Ljava_lang_String_);
			return cb_setParametro_Ljava_lang_String_;
		}

		static void n_SetParametro_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetParametro (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setParametro' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setParametro", "(Ljava/lang/String;)V", "GetSetParametro_Ljava_lang_String_Handler")]
		public virtual unsafe void SetParametro (string p0)
		{
			const string __id = "setParametro.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setParametroCartao_I;
#pragma warning disable 0169
		static Delegate GetSetParametroCartao_IHandler ()
		{
			if (cb_setParametroCartao_I == null)
				cb_setParametroCartao_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetParametroCartao_I);
			return cb_setParametroCartao_I;
		}

		static void n_SetParametroCartao_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetParametroCartao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setParametroCartao' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setParametroCartao", "(I)V", "GetSetParametroCartao_IHandler")]
		public virtual unsafe void SetParametroCartao (int p0)
		{
			const string __id = "setParametroCartao.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setParametroCartao_S;
#pragma warning disable 0169
		static Delegate GetSetParametroCartao_SHandler ()
		{
			if (cb_setParametroCartao_S == null)
				cb_setParametroCartao_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetParametroCartao_S);
			return cb_setParametroCartao_S;
		}

		static void n_SetParametroCartao_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetParametroCartao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setParametroCartao' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setParametroCartao", "(S)V", "GetSetParametroCartao_SHandler")]
		public virtual unsafe void SetParametroCartao (short p0)
		{
			const string __id = "setParametroCartao.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setParametrosAdicionais_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParametrosAdicionais_Ljava_lang_String_Handler ()
		{
			if (cb_setParametrosAdicionais_Ljava_lang_String_ == null)
				cb_setParametrosAdicionais_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParametrosAdicionais_Ljava_lang_String_);
			return cb_setParametrosAdicionais_Ljava_lang_String_;
		}

		static void n_SetParametrosAdicionais_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetParametrosAdicionais (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setParametrosAdicionais' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setParametrosAdicionais", "(Ljava/lang/String;)V", "GetSetParametrosAdicionais_Ljava_lang_String_Handler")]
		public virtual unsafe void SetParametrosAdicionais (string p0)
		{
			const string __id = "setParametrosAdicionais.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setProdutos_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProdutos_Ljava_lang_String_Handler ()
		{
			if (cb_setProdutos_Ljava_lang_String_ == null)
				cb_setProdutos_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProdutos_Ljava_lang_String_);
			return cb_setProdutos_Ljava_lang_String_;
		}

		static void n_SetProdutos_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetProdutos (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setProdutos' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setProdutos", "(Ljava/lang/String;)V", "GetSetProdutos_Ljava_lang_String_Handler")]
		public virtual unsafe void SetProdutos (string p0)
		{
			const string __id = "setProdutos.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setQuantidade_I;
#pragma warning disable 0169
		static Delegate GetSetQuantidade_IHandler ()
		{
			if (cb_setQuantidade_I == null)
				cb_setQuantidade_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetQuantidade_I);
			return cb_setQuantidade_I;
		}

		static void n_SetQuantidade_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQuantidade (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setQuantidade' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setQuantidade", "(I)V", "GetSetQuantidade_IHandler")]
		public virtual unsafe void SetQuantidade (int p0)
		{
			const string __id = "setQuantidade.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setQuantidade_S;
#pragma warning disable 0169
		static Delegate GetSetQuantidade_SHandler ()
		{
			if (cb_setQuantidade_S == null)
				cb_setQuantidade_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetQuantidade_S);
			return cb_setQuantidade_S;
		}

		static void n_SetQuantidade_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQuantidade (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setQuantidade' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setQuantidade", "(S)V", "GetSetQuantidade_SHandler")]
		public virtual unsafe void SetQuantidade (short p0)
		{
			const string __id = "setQuantidade.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setQuantidadeProduto_I;
#pragma warning disable 0169
		static Delegate GetSetQuantidadeProduto_IHandler ()
		{
			if (cb_setQuantidadeProduto_I == null)
				cb_setQuantidadeProduto_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetQuantidadeProduto_I);
			return cb_setQuantidadeProduto_I;
		}

		static void n_SetQuantidadeProduto_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQuantidadeProduto (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setQuantidadeProduto' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setQuantidadeProduto", "(I)V", "GetSetQuantidadeProduto_IHandler")]
		public virtual unsafe void SetQuantidadeProduto (int p0)
		{
			const string __id = "setQuantidadeProduto.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRedeDestino_I;
#pragma warning disable 0169
		static Delegate GetSetRedeDestino_IHandler ()
		{
			if (cb_setRedeDestino_I == null)
				cb_setRedeDestino_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRedeDestino_I);
			return cb_setRedeDestino_I;
		}

		static void n_SetRedeDestino_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRedeDestino (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setRedeDestino' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRedeDestino", "(I)V", "GetSetRedeDestino_IHandler")]
		public virtual unsafe void SetRedeDestino (int p0)
		{
			const string __id = "setRedeDestino.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRedeDestino_S;
#pragma warning disable 0169
		static Delegate GetSetRedeDestino_SHandler ()
		{
			if (cb_setRedeDestino_S == null)
				cb_setRedeDestino_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetRedeDestino_S);
			return cb_setRedeDestino_S;
		}

		static void n_SetRedeDestino_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRedeDestino (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setRedeDestino' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setRedeDestino", "(S)V", "GetSetRedeDestino_SHandler")]
		public virtual unsafe void SetRedeDestino (short p0)
		{
			const string __id = "setRedeDestino.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRestricoes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRestricoes_Ljava_lang_String_Handler ()
		{
			if (cb_setRestricoes_Ljava_lang_String_ == null)
				cb_setRestricoes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRestricoes_Ljava_lang_String_);
			return cb_setRestricoes_Ljava_lang_String_;
		}

		static void n_SetRestricoes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRestricoes (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setRestricoes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRestricoes", "(Ljava/lang/String;)V", "GetSetRestricoes_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRestricoes (string p0)
		{
			const string __id = "setRestricoes.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSenhaPinPad_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSenhaPinPad_Ljava_lang_String_Handler ()
		{
			if (cb_setSenhaPinPad_Ljava_lang_String_ == null)
				cb_setSenhaPinPad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSenhaPinPad_Ljava_lang_String_);
			return cb_setSenhaPinPad_Ljava_lang_String_;
		}

		static void n_SetSenhaPinPad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSenhaPinPad (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setSenhaPinPad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSenhaPinPad", "(Ljava/lang/String;)V", "GetSetSenhaPinPad_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSenhaPinPad (string p0)
		{
			const string __id = "setSenhaPinPad.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSequencial_I;
#pragma warning disable 0169
		static Delegate GetSetSequencial_IHandler ()
		{
			if (cb_setSequencial_I == null)
				cb_setSequencial_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSequencial_I);
			return cb_setSequencial_I;
		}

		static void n_SetSequencial_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSequencial (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setSequencial' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSequencial", "(I)V", "GetSetSequencial_IHandler")]
		public virtual unsafe void SetSequencial (int p0)
		{
			const string __id = "setSequencial.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSupervisor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSupervisor_Ljava_lang_String_Handler ()
		{
			if (cb_setSupervisor_Ljava_lang_String_ == null)
				cb_setSupervisor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSupervisor_Ljava_lang_String_);
			return cb_setSupervisor_Ljava_lang_String_;
		}

		static void n_SetSupervisor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSupervisor (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setSupervisor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSupervisor", "(Ljava/lang/String;)V", "GetSetSupervisor_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSupervisor (string p0)
		{
			const string __id = "setSupervisor.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTamDadosEntrada_I;
#pragma warning disable 0169
		static Delegate GetSetTamDadosEntrada_IHandler ()
		{
			if (cb_setTamDadosEntrada_I == null)
				cb_setTamDadosEntrada_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTamDadosEntrada_I);
			return cb_setTamDadosEntrada_I;
		}

		static void n_SetTamDadosEntrada_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTamDadosEntrada (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamDadosEntrada' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTamDadosEntrada", "(I)V", "GetSetTamDadosEntrada_IHandler")]
		public virtual unsafe void SetTamDadosEntrada (int p0)
		{
			const string __id = "setTamDadosEntrada.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTamDadosTx_I;
#pragma warning disable 0169
		static Delegate GetSetTamDadosTx_IHandler ()
		{
			if (cb_setTamDadosTx_I == null)
				cb_setTamDadosTx_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTamDadosTx_I);
			return cb_setTamDadosTx_I;
		}

		static void n_SetTamDadosTx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTamDadosTx (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamDadosTx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTamDadosTx", "(I)V", "GetSetTamDadosTx_IHandler")]
		public virtual unsafe void SetTamDadosTx (int p0)
		{
			const string __id = "setTamDadosTx.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTamDadosTx_S;
#pragma warning disable 0169
		static Delegate GetSetTamDadosTx_SHandler ()
		{
			if (cb_setTamDadosTx_S == null)
				cb_setTamDadosTx_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTamDadosTx_S);
			return cb_setTamDadosTx_S;
		}

		static void n_SetTamDadosTx_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTamDadosTx (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamDadosTx' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setTamDadosTx", "(S)V", "GetSetTamDadosTx_SHandler")]
		public virtual unsafe void SetTamDadosTx (short p0)
		{
			const string __id = "setTamDadosTx.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTamMaxDadosRx_I;
#pragma warning disable 0169
		static Delegate GetSetTamMaxDadosRx_IHandler ()
		{
			if (cb_setTamMaxDadosRx_I == null)
				cb_setTamMaxDadosRx_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTamMaxDadosRx_I);
			return cb_setTamMaxDadosRx_I;
		}

		static void n_SetTamMaxDadosRx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTamMaxDadosRx (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamMaxDadosRx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTamMaxDadosRx", "(I)V", "GetSetTamMaxDadosRx_IHandler")]
		public virtual unsafe void SetTamMaxDadosRx (int p0)
		{
			const string __id = "setTamMaxDadosRx.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTamMaxDadosRx_S;
#pragma warning disable 0169
		static Delegate GetSetTamMaxDadosRx_SHandler ()
		{
			if (cb_setTamMaxDadosRx_S == null)
				cb_setTamMaxDadosRx_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTamMaxDadosRx_S);
			return cb_setTamMaxDadosRx_S;
		}

		static void n_SetTamMaxDadosRx_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTamMaxDadosRx (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamMaxDadosRx' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setTamMaxDadosRx", "(S)V", "GetSetTamMaxDadosRx_SHandler")]
		public virtual unsafe void SetTamMaxDadosRx (short p0)
		{
			const string __id = "setTamMaxDadosRx.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTamMaxDadosServico_I;
#pragma warning disable 0169
		static Delegate GetSetTamMaxDadosServico_IHandler ()
		{
			if (cb_setTamMaxDadosServico_I == null)
				cb_setTamMaxDadosServico_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTamMaxDadosServico_I);
			return cb_setTamMaxDadosServico_I;
		}

		static void n_SetTamMaxDadosServico_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTamMaxDadosServico (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamMaxDadosServico' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTamMaxDadosServico", "(I)V", "GetSetTamMaxDadosServico_IHandler")]
		public virtual unsafe void SetTamMaxDadosServico (int p0)
		{
			const string __id = "setTamMaxDadosServico.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTamMaxDadosServico_S;
#pragma warning disable 0169
		static Delegate GetSetTamMaxDadosServico_SHandler ()
		{
			if (cb_setTamMaxDadosServico_S == null)
				cb_setTamMaxDadosServico_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTamMaxDadosServico_S);
			return cb_setTamMaxDadosServico_S;
		}

		static void n_SetTamMaxDadosServico_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTamMaxDadosServico (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamMaxDadosServico' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setTamMaxDadosServico", "(S)V", "GetSetTamMaxDadosServico_SHandler")]
		public virtual unsafe void SetTamMaxDadosServico (short p0)
		{
			const string __id = "setTamMaxDadosServico.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTamanhoMaximo_I;
#pragma warning disable 0169
		static Delegate GetSetTamanhoMaximo_IHandler ()
		{
			if (cb_setTamanhoMaximo_I == null)
				cb_setTamanhoMaximo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTamanhoMaximo_I);
			return cb_setTamanhoMaximo_I;
		}

		static void n_SetTamanhoMaximo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTamanhoMaximo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamanhoMaximo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTamanhoMaximo", "(I)V", "GetSetTamanhoMaximo_IHandler")]
		public virtual unsafe void SetTamanhoMaximo (int p0)
		{
			const string __id = "setTamanhoMaximo.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTamanhoMinimo_I;
#pragma warning disable 0169
		static Delegate GetSetTamanhoMinimo_IHandler ()
		{
			if (cb_setTamanhoMinimo_I == null)
				cb_setTamanhoMinimo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTamanhoMinimo_I);
			return cb_setTamanhoMinimo_I;
		}

		static void n_SetTamanhoMinimo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTamanhoMinimo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTamanhoMinimo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTamanhoMinimo", "(I)V", "GetSetTamanhoMinimo_IHandler")]
		public virtual unsafe void SetTamanhoMinimo (int p0)
		{
			const string __id = "setTamanhoMinimo.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTempoEsperaRx_I;
#pragma warning disable 0169
		static Delegate GetSetTempoEsperaRx_IHandler ()
		{
			if (cb_setTempoEsperaRx_I == null)
				cb_setTempoEsperaRx_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTempoEsperaRx_I);
			return cb_setTempoEsperaRx_I;
		}

		static void n_SetTempoEsperaRx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTempoEsperaRx (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTempoEsperaRx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTempoEsperaRx", "(I)V", "GetSetTempoEsperaRx_IHandler")]
		public virtual unsafe void SetTempoEsperaRx (int p0)
		{
			const string __id = "setTempoEsperaRx.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTempoEsperaRx_S;
#pragma warning disable 0169
		static Delegate GetSetTempoEsperaRx_SHandler ()
		{
			if (cb_setTempoEsperaRx_S == null)
				cb_setTempoEsperaRx_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTempoEsperaRx_S);
			return cb_setTempoEsperaRx_S;
		}

		static void n_SetTempoEsperaRx_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTempoEsperaRx (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTempoEsperaRx' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setTempoEsperaRx", "(S)V", "GetSetTempoEsperaRx_SHandler")]
		public virtual unsafe void SetTempoEsperaRx (short p0)
		{
			const string __id = "setTempoEsperaRx.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
		public virtual unsafe void SetTimeout (int p0)
		{
			const string __id = "setTimeout.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTimeout_S;
#pragma warning disable 0169
		static Delegate GetSetTimeout_SHandler ()
		{
			if (cb_setTimeout_S == null)
				cb_setTimeout_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTimeout_S);
			return cb_setTimeout_S;
		}

		static void n_SetTimeout_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setTimeout", "(S)V", "GetSetTimeout_SHandler")]
		public virtual unsafe void SetTimeout (short p0)
		{
			const string __id = "setTimeout.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTipoCancelamento_I;
#pragma warning disable 0169
		static Delegate GetSetTipoCancelamento_IHandler ()
		{
			if (cb_setTipoCancelamento_I == null)
				cb_setTipoCancelamento_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTipoCancelamento_I);
			return cb_setTipoCancelamento_I;
		}

		static void n_SetTipoCancelamento_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTipoCancelamento (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoCancelamento' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTipoCancelamento", "(I)V", "GetSetTipoCancelamento_IHandler")]
		public virtual unsafe void SetTipoCancelamento (int p0)
		{
			const string __id = "setTipoCancelamento.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTipoCancelamento_S;
#pragma warning disable 0169
		static Delegate GetSetTipoCancelamento_SHandler ()
		{
			if (cb_setTipoCancelamento_S == null)
				cb_setTipoCancelamento_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTipoCancelamento_S);
			return cb_setTipoCancelamento_S;
		}

		static void n_SetTipoCancelamento_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTipoCancelamento (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoCancelamento' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setTipoCancelamento", "(S)V", "GetSetTipoCancelamento_SHandler")]
		public virtual unsafe void SetTipoCancelamento (short p0)
		{
			const string __id = "setTipoCancelamento.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTipoCodigoEmBarras_I;
#pragma warning disable 0169
		static Delegate GetSetTipoCodigoEmBarras_IHandler ()
		{
			if (cb_setTipoCodigoEmBarras_I == null)
				cb_setTipoCodigoEmBarras_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTipoCodigoEmBarras_I);
			return cb_setTipoCodigoEmBarras_I;
		}

		static void n_SetTipoCodigoEmBarras_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTipoCodigoEmBarras (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoCodigoEmBarras' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTipoCodigoEmBarras", "(I)V", "GetSetTipoCodigoEmBarras_IHandler")]
		public virtual unsafe void SetTipoCodigoEmBarras (int p0)
		{
			const string __id = "setTipoCodigoEmBarras.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTipoConsulta_I;
#pragma warning disable 0169
		static Delegate GetSetTipoConsulta_IHandler ()
		{
			if (cb_setTipoConsulta_I == null)
				cb_setTipoConsulta_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTipoConsulta_I);
			return cb_setTipoConsulta_I;
		}

		static void n_SetTipoConsulta_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTipoConsulta (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoConsulta' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTipoConsulta", "(I)V", "GetSetTipoConsulta_IHandler")]
		public virtual unsafe void SetTipoConsulta (int p0)
		{
			const string __id = "setTipoConsulta.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTipoOperacao_I;
#pragma warning disable 0169
		static Delegate GetSetTipoOperacao_IHandler ()
		{
			if (cb_setTipoOperacao_I == null)
				cb_setTipoOperacao_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTipoOperacao_I);
			return cb_setTipoOperacao_I;
		}

		static void n_SetTipoOperacao_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTipoOperacao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoOperacao' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTipoOperacao", "(I)V", "GetSetTipoOperacao_IHandler")]
		public virtual unsafe void SetTipoOperacao (int p0)
		{
			const string __id = "setTipoOperacao.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTipoTransacao_I;
#pragma warning disable 0169
		static Delegate GetSetTipoTransacao_IHandler ()
		{
			if (cb_setTipoTransacao_I == null)
				cb_setTipoTransacao_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTipoTransacao_I);
			return cb_setTipoTransacao_I;
		}

		static void n_SetTipoTransacao_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTipoTransacao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoTransacao' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTipoTransacao", "(I)V", "GetSetTipoTransacao_IHandler")]
		public virtual unsafe void SetTipoTransacao (int p0)
		{
			const string __id = "setTipoTransacao.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTipoTransacao_S;
#pragma warning disable 0169
		static Delegate GetSetTipoTransacao_SHandler ()
		{
			if (cb_setTipoTransacao_S == null)
				cb_setTipoTransacao_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTipoTransacao_S);
			return cb_setTipoTransacao_S;
		}

		static void n_SetTipoTransacao_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTipoTransacao (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTipoTransacao' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setTipoTransacao", "(S)V", "GetSetTipoTransacao_SHandler")]
		public virtual unsafe void SetTipoTransacao (short p0)
		{
			const string __id = "setTipoTransacao.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTotalGeral_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTotalGeral_Ljava_lang_String_Handler ()
		{
			if (cb_setTotalGeral_Ljava_lang_String_ == null)
				cb_setTotalGeral_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTotalGeral_Ljava_lang_String_);
			return cb_setTotalGeral_Ljava_lang_String_;
		}

		static void n_SetTotalGeral_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTotalGeral (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTotalGeral' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTotalGeral", "(Ljava/lang/String;)V", "GetSetTotalGeral_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTotalGeral (string p0)
		{
			const string __id = "setTotalGeral.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTotalizador_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTotalizador_Ljava_lang_String_Handler ()
		{
			if (cb_setTotalizador_Ljava_lang_String_ == null)
				cb_setTotalizador_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTotalizador_Ljava_lang_String_);
			return cb_setTotalizador_Ljava_lang_String_;
		}

		static void n_SetTotalizador_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTotalizador (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setTotalizador' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTotalizador", "(Ljava/lang/String;)V", "GetSetTotalizador_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTotalizador (string p0)
		{
			const string __id = "setTotalizador.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setValor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValor_Ljava_lang_String_Handler ()
		{
			if (cb_setValor_Ljava_lang_String_ == null)
				cb_setValor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValor_Ljava_lang_String_);
			return cb_setValor_Ljava_lang_String_;
		}

		static void n_SetValor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValor (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setValor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setValor", "(Ljava/lang/String;)V", "GetSetValor_Ljava_lang_String_Handler")]
		public virtual unsafe void SetValor (string p0)
		{
			const string __id = "setValor.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setValorTotalBonus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValorTotalBonus_Ljava_lang_String_Handler ()
		{
			if (cb_setValorTotalBonus_Ljava_lang_String_ == null)
				cb_setValorTotalBonus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValorTotalBonus_Ljava_lang_String_);
			return cb_setValorTotalBonus_Ljava_lang_String_;
		}

		static void n_SetValorTotalBonus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValorTotalBonus (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setValorTotalBonus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setValorTotalBonus", "(Ljava/lang/String;)V", "GetSetValorTotalBonus_Ljava_lang_String_Handler")]
		public virtual unsafe void SetValorTotalBonus (string p0)
		{
			const string __id = "setValorTotalBonus.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setValorTotalCupon_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValorTotalCupon_Ljava_lang_String_Handler ()
		{
			if (cb_setValorTotalCupon_Ljava_lang_String_ == null)
				cb_setValorTotalCupon_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValorTotalCupon_Ljava_lang_String_);
			return cb_setValorTotalCupon_Ljava_lang_String_;
		}

		static void n_SetValorTotalCupon_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValorTotalCupon (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setValorTotalCupon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setValorTotalCupon", "(Ljava/lang/String;)V", "GetSetValorTotalCupon_Ljava_lang_String_Handler")]
		public virtual unsafe void SetValorTotalCupon (string p0)
		{
			const string __id = "setValorTotalCupon.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setValorUnitario_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValorUnitario_Ljava_lang_String_Handler ()
		{
			if (cb_setValorUnitario_Ljava_lang_String_ == null)
				cb_setValorUnitario_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValorUnitario_Ljava_lang_String_);
			return cb_setValorUnitario_Ljava_lang_String_;
		}

		static void n_SetValorUnitario_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValorUnitario (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='setValorUnitario' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setValorUnitario", "(Ljava/lang/String;)V", "GetSetValorUnitario_Ljava_lang_String_Handler")]
		public virtual unsafe void SetValorUnitario (string p0)
		{
			const string __id = "setValorUnitario.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_seteSenha_I;
#pragma warning disable 0169
		static Delegate GetSeteSenha_IHandler ()
		{
			if (cb_seteSenha_I == null)
				cb_seteSenha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SeteSenha_I);
			return cb_seteSenha_I;
		}

		static void n_SeteSenha_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeteSenha (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='seteSenha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("seteSenha", "(I)V", "GetSeteSenha_IHandler")]
		public virtual unsafe void SeteSenha (int p0)
		{
			const string __id = "seteSenha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_seteSenha_S;
#pragma warning disable 0169
		static Delegate GetSeteSenha_SHandler ()
		{
			if (cb_seteSenha_S == null)
				cb_seteSenha_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SeteSenha_S);
			return cb_seteSenha_S;
		}

		static void n_SeteSenha_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeteSenha (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='seteSenha' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("seteSenha", "(S)V", "GetSeteSenha_SHandler")]
		public virtual unsafe void SeteSenha (short p0)
		{
			const string __id = "seteSenha.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_validaCampoCodigoEmBarras;
#pragma warning disable 0169
		static Delegate GetValidaCampoCodigoEmBarrasHandler ()
		{
			if (cb_validaCampoCodigoEmBarras == null)
				cb_validaCampoCodigoEmBarras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ValidaCampoCodigoEmBarras);
			return cb_validaCampoCodigoEmBarras;
		}

		static int n_ValidaCampoCodigoEmBarras (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValidaCampoCodigoEmBarras ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='validaCampoCodigoEmBarras' and count(parameter)=0]"
		[Register ("validaCampoCodigoEmBarras", "()I", "GetValidaCampoCodigoEmBarrasHandler")]
		public virtual unsafe int ValidaCampoCodigoEmBarras ()
		{
			const string __id = "validaCampoCodigoEmBarras.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_validaCampoCodigoEmBarras_Ljava_lang_String_S;
#pragma warning disable 0169
		static Delegate GetValidaCampoCodigoEmBarras_Ljava_lang_String_SHandler ()
		{
			if (cb_validaCampoCodigoEmBarras_Ljava_lang_String_S == null)
				cb_validaCampoCodigoEmBarras_Ljava_lang_String_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, short, int>) n_ValidaCampoCodigoEmBarras_Ljava_lang_String_S);
			return cb_validaCampoCodigoEmBarras_Ljava_lang_String_S;
		}

		static int n_ValidaCampoCodigoEmBarras_Ljava_lang_String_S (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ValidaCampoCodigoEmBarras (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='validaCampoCodigoEmBarras' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short']]"
		[Register ("validaCampoCodigoEmBarras", "(Ljava/lang/String;S)I", "GetValidaCampoCodigoEmBarras_Ljava_lang_String_SHandler")]
		public virtual unsafe int ValidaCampoCodigoEmBarras (string p0, short p1)
		{
			const string __id = "validaCampoCodigoEmBarras.(Ljava/lang/String;S)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_verificaPresencaPinPad;
#pragma warning disable 0169
		static Delegate GetVerificaPresencaPinPadHandler ()
		{
			if (cb_verificaPresencaPinPad == null)
				cb_verificaPresencaPinPad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_VerificaPresencaPinPad);
			return cb_verificaPresencaPinPad;
		}

		static int n_VerificaPresencaPinPad (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.JCliSiTefI __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.JCliSiTefI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VerificaPresencaPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef']/class[@name='JCliSiTefI']/method[@name='verificaPresencaPinPad' and count(parameter)=0]"
		[Register ("verificaPresencaPinPad", "()I", "GetVerificaPresencaPinPadHandler")]
		public virtual unsafe int VerificaPresencaPinPad ()
		{
			const string __id = "verificaPresencaPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
