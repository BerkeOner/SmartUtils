using UnityEngine;

/*
    SmartUtils.TransformExtensions

    A lightweight extension library to simplify manipulating individual
    axes of a Transform in Unity. Normally, changing only one axis of
    position, rotation, or scale requires creating a new Vector3 or
    Quaternion. This library provides concise, readable, and safe 
    methods to modify just a single component.

    Example: Modifying only the Y-axis of an object's position.

    Old way:
        Vector3 targetPosition = transform.position;
        targetPosition.y = 0f;
        transform.position = targetPosition;

    New way (using SmartUtils):
        transform.Position().y = 0f;
*/

namespace SmartUtils
{
    public static class TransformExtensions
    {
        public static _Position Position(this Transform t) => new _Position(t);
        public static _LocalPosition LocalPosition(this Transform t) => new _LocalPosition(t);
        public static _Rotation Rotation(this Transform t) => new _Rotation(t);
        public static _LocalRotation LocalRotation(this Transform t) => new _LocalRotation(t);
        public static _Scale Scale(this Transform t) => new _Scale(t);

        public class _Position
        {
            private Transform t;
            public _Position(Transform t) { this.t = t; }

            public float x
            {
                get => t.position.x;
                set { var p = t.position; p.x = value; t.position = p; }
            }
            public float y
            {
                get => t.position.y;
                set { var p = t.position; p.y = value; t.position = p; }
            }
            public float z
            {
                get => t.position.z;
                set { var p = t.position; p.z = value; t.position = p; }
            }
        }

        public class _LocalPosition
        {
            private Transform t;
            public _LocalPosition(Transform t) { this.t = t; }

            public float x
            {
                get => t.localPosition.x;
                set { var p = t.localPosition; p.x = value; t.localPosition = p; }
            }
            public float y
            {
                get => t.localPosition.y;
                set { var p = t.localPosition; p.y = value; t.localPosition = p; }
            }
            public float z
            {
                get => t.localPosition.z;
                set { var p = t.localPosition; p.z = value; t.localPosition = p; }
            }
        }

        public class _Rotation
        {
            private Transform t;
            public _Rotation(Transform t) { this.t = t; }

            public float x
            {
                get => t.eulerAngles.x;
                set { var r = t.eulerAngles; r.x = value; t.eulerAngles = r; }
            }
            public float y
            {
                get => t.eulerAngles.y;
                set { var r = t.eulerAngles; r.y = value; t.eulerAngles = r; }
            }
            public float z
            {
                get => t.eulerAngles.z;
                set { var r = t.eulerAngles; r.z = value; t.eulerAngles = r; }
            }
        }

        public class _LocalRotation
        {
            private Transform t;
            public _LocalRotation(Transform t) { this.t = t; }

            public float x
            {
                get => t.localEulerAngles.x;
                set { var r = t.localEulerAngles; r.x = value; t.localEulerAngles = r; }
            }
            public float y
            {
                get => t.localEulerAngles.y;
                set { var r = t.localEulerAngles; r.y = value; t.localEulerAngles = r; }
            }
            public float z
            {
                get => t.localEulerAngles.z;
                set { var r = t.localEulerAngles; r.z = value; t.localEulerAngles = r; }
            }
        }

        public class _Scale
        {
            private Transform t;
            public _Scale(Transform t) { this.t = t; }

            public float x
            {
                get => t.localScale.x;
                set { var s = t.localScale; s.x = value; t.localScale = s; }
            }
            public float y
            {
                get => t.localScale.y;
                set { var s = t.localScale; s.y = value; t.localScale = s; }
            }
            public float z
            {
                get => t.localScale.z;
                set { var s = t.localScale; s.z = value; t.localScale = s; }
            }
        }
    }
}

