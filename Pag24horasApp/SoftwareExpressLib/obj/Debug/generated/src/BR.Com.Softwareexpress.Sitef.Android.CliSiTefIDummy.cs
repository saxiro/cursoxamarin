using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Softwareexpress.Sitef.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']"
	[global::Android.Runtime.Register ("br/com/softwareexpress/sitef/android/CliSiTefIDummy", DoNotGenerateAcw=true)]
	public partial class CliSiTefIDummy : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_CONFIRMA_CANCELA']"
		[Register ("CMD_CONFIRMA_CANCELA")]
		public const int CmdConfirmaCancela = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_EXIBE_CABECALHO']"
		[Register ("CMD_EXIBE_CABECALHO")]
		public const int CmdExibeCabecalho = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_MENSAGEM']"
		[Register ("CMD_MENSAGEM")]
		public const int CmdMensagem = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_MENSAGEM_CLIENTE']"
		[Register ("CMD_MENSAGEM_CLIENTE")]
		public const int CmdMensagemCliente = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_MENSAGEM_OPERADOR']"
		[Register ("CMD_MENSAGEM_OPERADOR")]
		public const int CmdMensagemOperador = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_OBTEM_CAMPO']"
		[Register ("CMD_OBTEM_CAMPO")]
		public const int CmdObtemCampo = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_OBTEM_CAMPO_SEM_COLETA']"
		[Register ("CMD_OBTEM_CAMPO_SEM_COLETA")]
		public const int CmdObtemCampoSemColeta = (int) 29;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_OBTEM_CHEQUE']"
		[Register ("CMD_OBTEM_CHEQUE")]
		public const int CmdObtemCheque = (int) 31;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_OBTEM_CODIGO_EM_BARRAS']"
		[Register ("CMD_OBTEM_CODIGO_EM_BARRAS")]
		public const int CmdObtemCodigoEmBarras = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_OBTEM_QUALQUER_TECLA']"
		[Register ("CMD_OBTEM_QUALQUER_TECLA")]
		public const int CmdObtemQualquerTecla = (int) 22;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_OBTEM_VALOR']"
		[Register ("CMD_OBTEM_VALOR")]
		public const int CmdObtemValor = (int) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_PERGUNTA_SE_INTERROMPE']"
		[Register ("CMD_PERGUNTA_SE_INTERROMPE")]
		public const int CmdPerguntaSeInterrompe = (int) 23;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_REMOVE_CABECALHO']"
		[Register ("CMD_REMOVE_CABECALHO")]
		public const int CmdRemoveCabecalho = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_REMOVE_MENSAGEM']"
		[Register ("CMD_REMOVE_MENSAGEM")]
		public const int CmdRemoveMensagem = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_REMOVE_MENSAGEM_CLIENTE']"
		[Register ("CMD_REMOVE_MENSAGEM_CLIENTE")]
		public const int CmdRemoveMensagemCliente = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_REMOVE_MENSAGEM_OPERADOR']"
		[Register ("CMD_REMOVE_MENSAGEM_OPERADOR")]
		public const int CmdRemoveMensagemOperador = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_REMOVE_TITULO_MENU']"
		[Register ("CMD_REMOVE_TITULO_MENU")]
		public const int CmdRemoveTituloMenu = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_RETORNO_VALOR']"
		[Register ("CMD_RETORNO_VALOR")]
		public const int CmdRetornoValor = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_SELECIONA_MENU']"
		[Register ("CMD_SELECIONA_MENU")]
		public const int CmdSelecionaMenu = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='CMD_TITULO_MENU']"
		[Register ("CMD_TITULO_MENU")]
		public const int CmdTituloMenu = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_CONTINUA_CADASTRO_PIN_BT']"
		[Register ("EVT_CONTINUA_CADASTRO_PIN_BT")]
		public const int EvtContinuaCadastroPinBt = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_FALHA_CADASTRO_PIN_BT']"
		[Register ("EVT_FALHA_CADASTRO_PIN_BT")]
		public const int EvtFalhaCadastroPinBt = (int) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_FIM_AGUARDA_CONEXAO_PP']"
		[Register ("EVT_FIM_AGUARDA_CONEXAO_PP")]
		public const int EvtFimAguardaConexaoPp = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_FIM_ATIVACAO_BT']"
		[Register ("EVT_FIM_ATIVACAO_BT")]
		public const int EvtFimAtivacaoBt = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_FIM_MODO_DISCOVER_BT']"
		[Register ("EVT_FIM_MODO_DISCOVER_BT")]
		public const int EvtFimModoDiscoverBt = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_INICIA_AGUARDA_CONEXAO_PP']"
		[Register ("EVT_INICIA_AGUARDA_CONEXAO_PP")]
		public const int EvtIniciaAguardaConexaoPp = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_INICIA_ATIVACAO_BT']"
		[Register ("EVT_INICIA_ATIVACAO_BT")]
		public const int EvtIniciaAtivacaoBt = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_INICIO_MODO_DISCOVER_BT']"
		[Register ("EVT_INICIO_MODO_DISCOVER_BT")]
		public const int EvtInicioModoDiscoverBt = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_PP_BT_CONFIGURADO']"
		[Register ("EVT_PP_BT_CONFIGURADO")]
		public const int EvtPpBtConfigurado = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_PP_BT_CONFIGURANDO']"
		[Register ("EVT_PP_BT_CONFIGURANDO")]
		public const int EvtPpBtConfigurando = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_PP_BT_DESCONECTADO']"
		[Register ("EVT_PP_BT_DESCONECTADO")]
		public const int EvtPpBtDesconectado = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/field[@name='EVT_SUCESSO_CADASTRO_PIN_BT']"
		[Register ("EVT_SUCESSO_CADASTRO_PIN_BT")]
		public const int EvtSucessoCadastroPinBt = (int) 32;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("br/com/softwareexpress/sitef/android/CliSiTefIDummy", typeof (CliSiTefIDummy));
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

		protected CliSiTefIDummy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/constructor[@name='CliSiTefIDummy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CliSiTefIDummy (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe string Buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getBuffer' and count(parameter)=0]"
			[Register ("getBuffer", "()Ljava/lang/String;", "GetGetBufferHandler")]
			get {
				const string __id = "getBuffer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='setBuffer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBuffer", "(Ljava/lang/String;)V", "GetSetBuffer_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBuffer.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static unsafe global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lbr/com/softwareexpress/sitef/android/CliSiTefIDummy;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lbr/com/softwareexpress/sitef/android/CliSiTefIDummy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int ProximoComando {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getProximoComando' and count(parameter)=0]"
			[Register ("getProximoComando", "()I", "GetGetProximoComandoHandler")]
			get {
				const string __id = "getProximoComando.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe short TamanhoMaximo {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getTamanhoMaximo' and count(parameter)=0]"
			[Register ("getTamanhoMaximo", "()S", "GetGetTamanhoMaximoHandler")]
			get {
				const string __id = "getTamanhoMaximo.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe short TamanhoMinimo {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getTamanhoMinimo' and count(parameter)=0]"
			[Register ("getTamanhoMinimo", "()S", "GetGetTamanhoMinimoHandler")]
			get {
				const string __id = "getTamanhoMinimo.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int TipoCampo {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getTipoCampo' and count(parameter)=0]"
			[Register ("getTipoCampo", "()I", "GetGetTipoCampoHandler")]
			get {
				const string __id = "getTipoCampo.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int TipoCodigoEmBarras {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getTipoCodigoEmBarras' and count(parameter)=0]"
			[Register ("getTipoCodigoEmBarras", "()I", "GetGetTipoCodigoEmBarrasHandler")]
			get {
				const string __id = "getTipoCodigoEmBarras.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVersao;
#pragma warning disable 0169
		static Delegate GetGetVersaoHandler ()
		{
			if (cb_getVersao == null)
				cb_getVersao = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersao);
			return cb_getVersao;
		}

		static IntPtr n_GetVersao (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Versao);
		}
#pragma warning restore 0169

		public virtual unsafe string Versao {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getVersao' and count(parameter)=0]"
			[Register ("getVersao", "()Ljava/lang/String;", "GetGetVersaoHandler")]
			get {
				const string __id = "getVersao.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersaoCliSiTef);
		}
#pragma warning restore 0169

		public virtual unsafe string VersaoCliSiTef {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getVersaoCliSiTef' and count(parameter)=0]"
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersaoCliSiTefI);
		}
#pragma warning restore 0169

		public virtual unsafe string VersaoCliSiTefI {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getVersaoCliSiTefI' and count(parameter)=0]"
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

		public static unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_carregaArquivosTraducao_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCarregaArquivosTraducao_Ljava_lang_String_Handler ()
		{
			if (cb_carregaArquivosTraducao_Ljava_lang_String_ == null)
				cb_carregaArquivosTraducao_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CarregaArquivosTraducao_Ljava_lang_String_);
			return cb_carregaArquivosTraducao_Ljava_lang_String_;
		}

		static int n_CarregaArquivosTraducao_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CarregaArquivosTraducao (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='carregaArquivosTraducao' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("carregaArquivosTraducao", "(Ljava/lang/String;)I", "GetCarregaArquivosTraducao_Ljava_lang_String_Handler")]
		public virtual unsafe int CarregaArquivosTraducao (string p0)
		{
			const string __id = "carregaArquivosTraducao.(Ljava/lang/String;)I";
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CarregaArquivosTraducao (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='carregaArquivosTraducao' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConfiguraIntSiTefInterativoEx (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='configuraIntSiTefInterativoEx' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContinuaFuncaoSiTefInterativo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='continuaFuncaoSiTefInterativo' and count(parameter)=0]"
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

		static Delegate cb_continuaFuncaoSiTefInterativo_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetContinuaFuncaoSiTefInterativo_Ljava_lang_String_IHandler ()
		{
			if (cb_continuaFuncaoSiTefInterativo_Ljava_lang_String_I == null)
				cb_continuaFuncaoSiTefInterativo_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_ContinuaFuncaoSiTefInterativo_Ljava_lang_String_I);
			return cb_continuaFuncaoSiTefInterativo_Ljava_lang_String_I;
		}

		static int n_ContinuaFuncaoSiTefInterativo_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ContinuaFuncaoSiTefInterativo (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='continuaFuncaoSiTefInterativo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("continuaFuncaoSiTefInterativo", "(Ljava/lang/String;I)I", "GetContinuaFuncaoSiTefInterativo_Ljava_lang_String_IHandler")]
		public virtual unsafe int ContinuaFuncaoSiTefInterativo (string p0, int p1)
		{
			const string __id = "continuaFuncaoSiTefInterativo.(Ljava/lang/String;I)I";
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CorrespondenteBancarioSiTefInterativo (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='correspondenteBancarioSiTefInterativo' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescarregaMensagens ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='descarregaMensagens' and count(parameter)=0]"
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EscreveMensagemPermanentePinPad (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='escreveMensagemPermanentePinPad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_finalizaTransacaoSiTefInterativoEx_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinalizaTransacaoSiTefInterativoEx_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finalizaTransacaoSiTefInterativoEx_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finalizaTransacaoSiTefInterativoEx_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_FinalizaTransacaoSiTefInterativoEx_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finalizaTransacaoSiTefInterativoEx_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_FinalizaTransacaoSiTefInterativoEx_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FinalizaTransacaoSiTefInterativoEx (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='finalizaTransacaoSiTefInterativoEx' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("finalizaTransacaoSiTefInterativoEx", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "GetFinalizaTransacaoSiTefInterativoEx_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int FinalizaTransacaoSiTefInterativoEx (int p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "finalizaTransacaoSiTefInterativoEx.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I";
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='iniciaFuncaoSiTefInterativo' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
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

		static Delegate cb_leCartaoDiretoSeguro_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeCartaoDiretoSeguro_Ljava_lang_String_Handler ()
		{
			if (cb_leCartaoDiretoSeguro_Ljava_lang_String_ == null)
				cb_leCartaoDiretoSeguro_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeCartaoDiretoSeguro_Ljava_lang_String_);
			return cb_leCartaoDiretoSeguro_Ljava_lang_String_;
		}

		static int n_LeCartaoDiretoSeguro_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeCartaoDiretoSeguro (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='leCartaoDiretoSeguro' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leCartaoDiretoSeguro", "(Ljava/lang/String;)I", "GetLeCartaoDiretoSeguro_Ljava_lang_String_Handler")]
		public virtual unsafe int LeCartaoDiretoSeguro (string p0)
		{
			const string __id = "leCartaoDiretoSeguro.(Ljava/lang/String;)I";
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

		static Delegate cb_leSenhaDireto_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeSenhaDireto_Ljava_lang_String_Handler ()
		{
			if (cb_leSenhaDireto_Ljava_lang_String_ == null)
				cb_leSenhaDireto_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LeSenhaDireto_Ljava_lang_String_);
			return cb_leSenhaDireto_Ljava_lang_String_;
		}

		static int n_LeSenhaDireto_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeSenhaDireto (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='leSenhaDireto' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leSenhaDireto", "(Ljava/lang/String;)I", "GetLeSenhaDireto_Ljava_lang_String_Handler")]
		public virtual unsafe int LeSenhaDireto (string p0)
		{
			const string __id = "leSenhaDireto.(Ljava/lang/String;)I";
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeSimNaoPinPad (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='leSimNaoPinPad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObtemInformacoesPinPad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='obtemInformacoesPinPad' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='obtemQuantidadeTransacoesPendentes' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("obtemQuantidadeTransacoesPendentes", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public unsafe int ObtemQuantidadeTransacoesPendentes (string p0, string p1)
		{
			const string __id = "obtemQuantidadeTransacoesPendentes.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='obtemVersao' and count(parameter)=0]"
		[Register ("obtemVersao", "()I", "")]
		public unsafe int ObtemVersao ()
		{
			const string __id = "obtemVersao.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pinpadConecta;
#pragma warning disable 0169
		static Delegate GetPinpadConectaHandler ()
		{
			if (cb_pinpadConecta == null)
				cb_pinpadConecta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_PinpadConecta);
			return cb_pinpadConecta;
		}

		static int n_PinpadConecta (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PinpadConecta ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='pinpadConecta' and count(parameter)=0]"
		[Register ("pinpadConecta", "()I", "GetPinpadConectaHandler")]
		public virtual unsafe int PinpadConecta ()
		{
			const string __id = "pinpadConecta.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pinpadDesconecta;
#pragma warning disable 0169
		static Delegate GetPinpadDesconectaHandler ()
		{
			if (cb_pinpadDesconecta == null)
				cb_pinpadDesconecta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_PinpadDesconecta);
			return cb_pinpadDesconecta;
		}

		static int n_PinpadDesconecta (IntPtr jnienv, IntPtr native__this)
		{
			global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy __this = global::Java.Lang.Object.GetObject<global::BR.Com.Softwareexpress.Sitef.Android.CliSiTefIDummy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PinpadDesconecta ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='pinpadDesconecta' and count(parameter)=0]"
		[Register ("pinpadDesconecta", "()I", "GetPinpadDesconectaHandler")]
		public virtual unsafe int PinpadDesconecta ()
		{
			const string __id = "pinpadDesconecta.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='setContinuaNavegacao' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContinuaNavegacao", "(I)V", "")]
		public unsafe void SetContinuaNavegacao (int p0)
		{
			const string __id = "setContinuaNavegacao.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "")]
		public unsafe void SetDebug (bool p0)
		{
			const string __id = "setDebug.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='validaCampoCodigoEmBarras' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validaCampoCodigoEmBarras", "(Ljava/lang/String;)I", "")]
		public unsafe int ValidaCampoCodigoEmBarras (string p0)
		{
			const string __id = "validaCampoCodigoEmBarras.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.softwareexpress.sitef.android']/class[@name='CliSiTefIDummy']/method[@name='verificaPresencaPinPad' and count(parameter)=0]"
		[Register ("verificaPresencaPinPad", "()I", "")]
		public unsafe int VerificaPresencaPinPad ()
		{
			const string __id = "verificaPresencaPinPad.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
