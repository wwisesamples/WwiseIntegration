/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Playlist : AkPlaylistArray {
  private HandleRef swigCPtr;

  internal Playlist(IntPtr cPtr, bool cMemoryOwn) : base(AkSoundEnginePINVOKE.CSharp_Playlist_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Playlist obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Playlist() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_Playlist(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfo in_pExternalSources) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_Playlist_Enqueue__SWIG_0(swigCPtr, in_audioNodeID, in_msDelay, in_pCustomInfo, in_cExternals, AkExternalSourceInfo.getCPtr(in_pExternalSources));

    return ret;
  }

  public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_Playlist_Enqueue__SWIG_1(swigCPtr, in_audioNodeID, in_msDelay, in_pCustomInfo, in_cExternals);

    return ret;
  }

  public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_Playlist_Enqueue__SWIG_2(swigCPtr, in_audioNodeID, in_msDelay, in_pCustomInfo);

    return ret;
  }

  public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_Playlist_Enqueue__SWIG_3(swigCPtr, in_audioNodeID, in_msDelay);

    return ret;
  }

  public AKRESULT Enqueue(uint in_audioNodeID) {
    AKRESULT ret = (AKRESULT)AkSoundEnginePINVOKE.CSharp_Playlist_Enqueue__SWIG_4(swigCPtr, in_audioNodeID);

    return ret;
  }

  public Playlist() : this(AkSoundEnginePINVOKE.CSharp_new_Playlist(), true) {

  }

}
