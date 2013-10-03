#if UNITY_STANDALONE_WIN || (UNITY_EDITOR && UNITY_STANDALONE_WIN) || (UNITY_EDITOR && UNITY_XBOX360) || (UNITY_EDITOR && UNITY_PS3) || (UNITY_EDITOR && UNITY_ANDROID)
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkThreadProperties : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AkThreadProperties(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AkThreadProperties obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AkThreadProperties() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkThreadProperties(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int nPriority {
    set {
      AkSoundEnginePINVOKE.CSharp_AkThreadProperties_nPriority_set(swigCPtr, value);

    } 
    get {
      int ret = AkSoundEnginePINVOKE.CSharp_AkThreadProperties_nPriority_get(swigCPtr);

      return ret;
    } 
  }

  public uint dwAffinityMask {
    set {
      AkSoundEnginePINVOKE.CSharp_AkThreadProperties_dwAffinityMask_set(swigCPtr, value);

    } 
    get {
      uint ret = AkSoundEnginePINVOKE.CSharp_AkThreadProperties_dwAffinityMask_get(swigCPtr);

      return ret;
    } 
  }

  public uint uStackSize {
    set {
      AkSoundEnginePINVOKE.CSharp_AkThreadProperties_uStackSize_set(swigCPtr, value);

    } 
    get {
      uint ret = AkSoundEnginePINVOKE.CSharp_AkThreadProperties_uStackSize_get(swigCPtr);

      return ret;
    } 
  }

  public AkThreadProperties() : this(AkSoundEnginePINVOKE.CSharp_new_AkThreadProperties(), true) {

  }

}

#endif // #if UNITY_STANDALONE_WIN || (UNITY_EDITOR && UNITY_STANDALONE_WIN) || (UNITY_EDITOR && UNITY_XBOX360) || (UNITY_EDITOR && UNITY_PS3) || (UNITY_EDITOR && UNITY_ANDROID)
