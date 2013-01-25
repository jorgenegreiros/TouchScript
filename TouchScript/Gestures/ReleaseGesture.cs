﻿/*
 * Copyright (C) 2012 Interactive Lab
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the 
 * 
 */

using System.Collections.Generic;
using UnityEngine;

namespace TouchScript.Gestures {
    /// <summary>
    /// Recognizes when last touch is released from target.
    /// Works with any gesture unless a Delegate is set.
    /// </summary>
    [AddComponentMenu("TouchScript/Gestures/Release Gesture")]
    public class ReleaseGesture : Gesture {
        public override bool CanPreventGesture(Gesture gesture) {
            if (Delegate == null) return false;
            return Delegate.ShouldRecognizeSimultaneously(this, gesture);
        }

        public override bool CanBePreventedByGesture(Gesture gesture) {
            if (Delegate == null) return false;
            return !Delegate.ShouldRecognizeSimultaneously(this, gesture);
        }

        protected override void touchesEnded(IList<TouchPoint> touches) {
            if (activeTouches.Count == 0) setState(GestureState.Recognized);
        }
    }
}