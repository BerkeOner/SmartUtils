using System;
using System.Collections;
using UnityEngine;

namespace SmartUtils
{
    public static class DelayIt
    {
        public static IEnumerator LateStart(int frames, Action action)
        {
            while (frames > 0)
            {
                frames--;
                yield return null;
            }

            action();
        }

        public static IEnumerator LateStart(float seconds, Action action)
        {
            if (seconds > 0)
                yield return new WaitForSeconds(seconds);

            action();
        }

        public static IEnumerator LateStartWithCondition(int frames, bool conditionItself, Action action)
        {
            while (frames > 0)
            {
                frames--;
                yield return null;
            }

            yield return new WaitUntil(() => conditionItself);

            action();
        }

        public static IEnumerator LateStartWithCondition(bool conditionItself, int frames, Action action)
        {
            yield return new WaitUntil(() => conditionItself);

            while (frames > 0)
            {
                frames--;
                yield return null;
            }

            action();
        }

        public static IEnumerator LateStartWithCondition(float seconds, bool conditionItself, Action action)
        {
            if (seconds > 0)
                yield return new WaitForSeconds(seconds);

            yield return new WaitUntil(() => conditionItself);

            action();
        }

        public static IEnumerator LateStartWithCondition(bool conditionItself, float seconds, Action action)
        {
            yield return new WaitUntil(() => conditionItself);

            if (seconds > 0)
                yield return new WaitForSeconds(seconds);

            action();
        }
    }
}