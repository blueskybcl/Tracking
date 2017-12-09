using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amap.Api.Services.Help
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']"
    [global::Android.Runtime.Register("com/amap/api/services/help/Inputtips", DoNotGenerateAcw = true)]
    public sealed partial class Inputtips : global::Java.Lang.Object
    {

        // Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.services.help']/interface[@name='Inputtips.InputtipsListener']"
        [Register("com/amap/api/services/help/Inputtips$InputtipsListener", "", "Com.Amap.Api.Services.Help.Inputtips/IInputtipsListenerInvoker")]
        public partial interface IInputtipsListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.help']/interface[@name='Inputtips.InputtipsListener']/method[@name='onGetInputtips' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.amap.api.services.help.Tip&gt;'] and parameter[2][@type='int']]"
            [Register("onGetInputtips", "(Ljava/util/List;I)V", "GetOnGetInputtips_Ljava_util_List_IHandler:Com.Amap.Api.Services.Help.Inputtips/IInputtipsListenerInvoker, AutoNavMapBinding.Droid")]
            void OnGetInputtips(global::System.Collections.Generic.IList<global::Com.Amap.Api.Services.Help.Tip> p0, int p1);

        }

        [global::Android.Runtime.Register("com/amap/api/services/help/Inputtips$InputtipsListener", DoNotGenerateAcw = true)]
        internal class IInputtipsListenerInvoker : global::Java.Lang.Object, IInputtipsListener
        {

            static IntPtr java_class_ref = JNIEnv.FindClass("com/amap/api/services/help/Inputtips$InputtipsListener");

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(IInputtipsListenerInvoker); }
            }

            IntPtr class_ref;

            public static IInputtipsListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IInputtipsListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.amap.api.services.help.Inputtips.InputtipsListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IInputtipsListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onGetInputtips_Ljava_util_List_I;
#pragma warning disable 0169
            static Delegate GetOnGetInputtips_Ljava_util_List_IHandler()
            {
                if (cb_onGetInputtips_Ljava_util_List_I == null)
                    cb_onGetInputtips_Ljava_util_List_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int>)n_OnGetInputtips_Ljava_util_List_I);
                return cb_onGetInputtips_Ljava_util_List_I;
            }

            static void n_OnGetInputtips_Ljava_util_List_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
            {
                global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Services.Help.Tip>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.OnGetInputtips(p0, p1);
            }
#pragma warning restore 0169

            IntPtr id_onGetInputtips_Ljava_util_List_I;
            public unsafe void OnGetInputtips(global::System.Collections.Generic.IList<global::Com.Amap.Api.Services.Help.Tip> p0, int p1)
            {
                if (id_onGetInputtips_Ljava_util_List_I == IntPtr.Zero)
                    id_onGetInputtips_Ljava_util_List_I = JNIEnv.GetMethodID(class_ref, "onGetInputtips", "(Ljava/util/List;I)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Services.Help.Tip>.ToLocalJniHandle(p0);
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(native_p0);
                __args[1] = new JValue(p1);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onGetInputtips_Ljava_util_List_I, __args);
                JNIEnv.DeleteLocalRef(native_p0);
            }

        }

        public partial class InputtipsEventArgs : global::System.EventArgs
        {

            public InputtipsEventArgs(global::System.Collections.Generic.IList<global::Com.Amap.Api.Services.Help.Tip> p0, int p1)
            {
                this.p0 = p0;
                this.p1 = p1;
            }

            global::System.Collections.Generic.IList<global::Com.Amap.Api.Services.Help.Tip> p0;
            public global::System.Collections.Generic.IList<global::Com.Amap.Api.Services.Help.Tip> P0
            {
                get { return p0; }
            }

            int p1;
            public int P1
            {
                get { return p1; }
            }
        }

        [global::Android.Runtime.Register("mono/com/amap/api/services/help/Inputtips_InputtipsListenerImplementor")]
        internal sealed partial class IInputtipsListenerImplementor : global::Java.Lang.Object, IInputtipsListener
        {

            object sender;

            public IInputtipsListenerImplementor(object sender)
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/amap/api/services/help/Inputtips_InputtipsListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                this.sender = sender;
            }

#pragma warning disable 0649
            public EventHandler<InputtipsEventArgs> Handler;
#pragma warning restore 0649

            public void OnGetInputtips(global::System.Collections.Generic.IList<global::Com.Amap.Api.Services.Help.Tip> p0, int p1)
            {
                var __h = Handler;
                if (__h != null)
                    __h(sender, new InputtipsEventArgs(p0, p1));
            }

            internal static bool __IsEmpty(IInputtipsListenerImplementor value)
            {
                return value.Handler == null;
            }
        }


        internal static new IntPtr java_class_handle;
        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/amap/api/services/help/Inputtips", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(Inputtips); }
        }

        internal Inputtips(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_Inputtips_InputtipsListener_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']/constructor[@name='Inputtips' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amap.api.services.help.Inputtips.InputtipsListener']]"
        [Register(".ctor", "(Landroid/content/Context;Lcom/amap/api/services/help/Inputtips$InputtipsListener;)V", "")]
        public unsafe Inputtips(global::Android.Content.Context p0, global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListener p1)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                if (((object)this).GetType() != typeof(Inputtips))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Landroid/content/Context;Lcom/amap/api/services/help/Inputtips$InputtipsListener;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(Landroid/content/Context;Lcom/amap/api/services/help/Inputtips$InputtipsListener;)V", __args);
                    return;
                }

                if (id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_Inputtips_InputtipsListener_ == IntPtr.Zero)
                    id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_Inputtips_InputtipsListener_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Landroid/content/Context;Lcom/amap/api/services/help/Inputtips$InputtipsListener;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_Inputtips_InputtipsListener_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_Inputtips_InputtipsListener_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_InputtipsQuery_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']/constructor[@name='Inputtips' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.amap.api.services.help.InputtipsQuery']]"
        [Register(".ctor", "(Landroid/content/Context;Lcom/amap/api/services/help/InputtipsQuery;)V", "")]
        public unsafe Inputtips(global::Android.Content.Context p0, global::Com.Amap.Api.Services.Help.InputtipsQuery p1)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                if (((object)this).GetType() != typeof(Inputtips))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Landroid/content/Context;Lcom/amap/api/services/help/InputtipsQuery;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(Landroid/content/Context;Lcom/amap/api/services/help/InputtipsQuery;)V", __args);
                    return;
                }

                if (id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_InputtipsQuery_ == IntPtr.Zero)
                    id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_InputtipsQuery_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Landroid/content/Context;Lcom/amap/api/services/help/InputtipsQuery;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_InputtipsQuery_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_amap_api_services_help_InputtipsQuery_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getQuery;
        static IntPtr id_setQuery_Lcom_amap_api_services_help_InputtipsQuery_;
        public unsafe global::Com.Amap.Api.Services.Help.InputtipsQuery Query
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']/method[@name='getQuery' and count(parameter)=0]"
            [Register("getQuery", "()Lcom/amap/api/services/help/InputtipsQuery;", "GetGetQueryHandler")]
            get
            {
                if (id_getQuery == IntPtr.Zero)
                    id_getQuery = JNIEnv.GetMethodID(class_ref, "getQuery", "()Lcom/amap/api/services/help/InputtipsQuery;");
                try
                {
                    return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Services.Help.InputtipsQuery>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']/method[@name='setQuery' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.help.InputtipsQuery']]"
            [Register("setQuery", "(Lcom/amap/api/services/help/InputtipsQuery;)V", "GetSetQuery_Lcom_amap_api_services_help_InputtipsQuery_Handler")]
            set
            {
                if (id_setQuery_Lcom_amap_api_services_help_InputtipsQuery_ == IntPtr.Zero)
                    id_setQuery_Lcom_amap_api_services_help_InputtipsQuery_ = JNIEnv.GetMethodID(class_ref, "setQuery", "(Lcom/amap/api/services/help/InputtipsQuery;)V");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(value);
                    JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setQuery_Lcom_amap_api_services_help_InputtipsQuery_, __args);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_requestInputtips;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']/method[@name='requestInputtips' and count(parameter)=0]"
        [Register("requestInputtips", "()Ljava/util/List;", "")]
        public unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Services.Help.Tip> RequestInputtips()
        {
            if (id_requestInputtips == IntPtr.Zero)
                id_requestInputtips = JNIEnv.GetMethodID(class_ref, "requestInputtips", "()Ljava/util/List;");
            try
            {
                return global::Android.Runtime.JavaList<global::Com.Amap.Api.Services.Help.Tip>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_requestInputtips), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static IntPtr id_requestInputtips_Ljava_lang_String_Ljava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']/method[@name='requestInputtips' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
        [Register("requestInputtips", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
        public unsafe void RequestInputtips(string p0, string p1)
        {
            if (id_requestInputtips_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
                id_requestInputtips_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "requestInputtips", "(Ljava/lang/String;Ljava/lang/String;)V");
            IntPtr native_p0 = JNIEnv.NewString(p0);
            IntPtr native_p1 = JNIEnv.NewString(p1);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(native_p0);
                __args[1] = new JValue(native_p1);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_requestInputtips_Ljava_lang_String_Ljava_lang_String_, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
                JNIEnv.DeleteLocalRef(native_p1);
            }
        }

        static IntPtr id_requestInputtips_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']/method[@name='requestInputtips' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
        [Register("requestInputtips", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
        public unsafe void RequestInputtips(string p0, string p1, string p2)
        {
            if (id_requestInputtips_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
                id_requestInputtips_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "requestInputtips", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
            IntPtr native_p0 = JNIEnv.NewString(p0);
            IntPtr native_p1 = JNIEnv.NewString(p1);
            IntPtr native_p2 = JNIEnv.NewString(p2);
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(native_p0);
                __args[1] = new JValue(native_p1);
                __args[2] = new JValue(native_p2);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_requestInputtips_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
                JNIEnv.DeleteLocalRef(native_p1);
                JNIEnv.DeleteLocalRef(native_p2);
            }
        }

        static IntPtr id_requestInputtipsAsyn;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']/method[@name='requestInputtipsAsyn' and count(parameter)=0]"
        [Register("requestInputtipsAsyn", "()V", "")]
        public unsafe void RequestInputtipsAsyn()
        {
            if (id_requestInputtipsAsyn == IntPtr.Zero)
                id_requestInputtipsAsyn = JNIEnv.GetMethodID(class_ref, "requestInputtipsAsyn", "()V");
            try
            {
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_requestInputtipsAsyn);
            }
            finally
            {
            }
        }

        static IntPtr id_setInputtipsListener_Lcom_amap_api_services_help_Inputtips_InputtipsListener_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.services.help']/class[@name='Inputtips']/method[@name='setInputtipsListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.services.help.Inputtips.InputtipsListener']]"
        [Register("setInputtipsListener", "(Lcom/amap/api/services/help/Inputtips$InputtipsListener;)V", "")]
        public unsafe void SetInputtipsListener(global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListener p0)
        {
            if (id_setInputtipsListener_Lcom_amap_api_services_help_Inputtips_InputtipsListener_ == IntPtr.Zero)
                id_setInputtipsListener_Lcom_amap_api_services_help_Inputtips_InputtipsListener_ = JNIEnv.GetMethodID(class_ref, "setInputtipsListener", "(Lcom/amap/api/services/help/Inputtips$InputtipsListener;)V");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_setInputtipsListener_Lcom_amap_api_services_help_Inputtips_InputtipsListener_, __args);
            }
            finally
            {
            }
        }

        #region "Event implementation for Com.Amap.Api.Services.Help.Inputtips.IInputtipsListener"
        public event EventHandler<global::Com.Amap.Api.Services.Help.Inputtips.InputtipsEventArgs> InputtipsEvent
        {
            add
            {
                global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListener, global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListenerImplementor>(
                        ref weak_implementor_SetInputtipsListener,
                        __CreateIInputtipsListenerImplementor,
                        SetInputtipsListener,
                        __h => __h.Handler += value);
            }
            remove
            {
                global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListener, global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListenerImplementor>(
                        ref weak_implementor_SetInputtipsListener,
                        global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListenerImplementor.__IsEmpty,
                        __v => SetInputtipsListener(null),
                        __h => __h.Handler -= value);
            }
        }

        WeakReference weak_implementor_SetInputtipsListener;

        global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListenerImplementor __CreateIInputtipsListenerImplementor()
        {
            return new global::Com.Amap.Api.Services.Help.Inputtips.IInputtipsListenerImplementor(this);
        }
        #endregion
    }
}
