/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkSoundPosition : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AkSoundPosition(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AkSoundPosition obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AkSoundPosition() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkSoundPosition(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public AkVector Position {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSoundPosition_Position_set(swigCPtr, AkVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkSoundPosition_Position_get(swigCPtr);
      AkVector ret = (cPtr == IntPtr.Zero) ? null : new AkVector(cPtr, false);
      return ret;
    } 
  }

  public AkVector Orientation {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSoundPosition_Orientation_set(swigCPtr, AkVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkSoundPosition_Orientation_get(swigCPtr);
      AkVector ret = (cPtr == IntPtr.Zero) ? null : new AkVector(cPtr, false);
      return ret;
    } 
  }

  public AkSoundPosition() : this(AkSoundEnginePINVOKE.CSharp_new_AkSoundPosition(), true) {

  }

}
