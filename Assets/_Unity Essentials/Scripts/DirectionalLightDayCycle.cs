using UnityEngine;

namespace UniSteps.Gallery
{
    /// <summary>
    /// Directional Lightを一定周期で回転させ、昼夜サイクルを表現する。
    /// </summary>
    public sealed class DirectionalLightDayCycle : MonoBehaviour
    {
        [SerializeField, Min(0.1f)]
        [Tooltip("1日(ライトが360度回転する)にかかる秒数。")]
        private float dayDurationSeconds = 120f;

        [SerializeField]
        [Tooltip("回転軸。通常はX軸(Vector3.right)で太陽の動きを表現。")]
        private Vector3 rotationAxis = Vector3.right;

        private void Update()
        {
            if (dayDurationSeconds <= 0f)
            {
                return;
            }

            float degreesPerSecond = 360f / dayDurationSeconds;
            transform.Rotate(rotationAxis.normalized, degreesPerSecond * Time.deltaTime, Space.Self);
        }
    }
}
