﻿/*
 * @author Valentin Simonov / http://va.lent.in/
 */

using TouchScript.Gestures.Simple;
using UnityEditor;
using UnityEngine;

namespace TouchScript.Editor.Gestures.Simple
{
    [CustomEditor(typeof(SimplePanGesture))]
    public class SimplePanGestureEditor : Transform2DGestureBaseEditor
    {
        public const string TEXT_MOVEMENTTHRESHOLD = "Minimum distance in cm touch points must move for the gesture to begin.";

        private SerializedProperty movementThreshold;

        protected override void OnEnable()
        {
            base.OnEnable();

            movementThreshold = serializedObject.FindProperty("movementThreshold");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.UpdateIfDirtyOrScript();

            EditorGUILayout.PropertyField(movementThreshold, new GUIContent("Movement Threshold (cm)", TEXT_MOVEMENTTHRESHOLD));

            serializedObject.ApplyModifiedProperties();
            base.OnInspectorGUI();
        }
    }
}