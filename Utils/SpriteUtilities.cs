using System.Collections;
using UnityEngine;

public static class SpriteUtilities {
    public static IEnumerator ChangeAndReturnScale(SpriteRenderer _sprite, Vector2 _scaleToChange, float _timeToGoBack, Vector2 _originalScale) {
        _sprite.transform.localScale = _scaleToChange;
        yield return new WaitForSeconds(_timeToGoBack);
        _sprite.transform.localScale = _originalScale;
    }
}
