using System.Collections;
using UnityEngine;

public class DestroyAfter : MonoBehaviour {
    [SerializeField]
    private float TimeToDestroy = 0.5f;

    private void Start() {
        StartCoroutine(WaitUntilDestroy(TimeToDestroy));
    }

    private IEnumerator WaitUntilDestroy(float Time) {
        yield return new WaitForSecondsRealtime(Time);
        Destroy(gameObject);
    }
}
