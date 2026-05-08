using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameUtils : MonoBehaviour
{
    // Статическая ссылка на себя
    public static GameUtils Instance { get; private set; }

    private void Awake()
    {
        // Если экземпляр уже существует — удаляем дубликат
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        // Объект не удалится при смене сцены
        DontDestroyOnLoad(gameObject);
    }


    public void beGood()
    {
        GameData.karma += 1;
        GameData.lastChoice = 1;
    }

    public void beBad()
    {
        GameData.karma -= 1;
        GameData.lastChoice = -1;
    }

    public void FadeIn(GameObject target, float duration)
    {
        StartCoroutine(FadeRoutine(target, duration, 1f));
    }
    public void FadeOut(GameObject target, float duration)
    {
        StartCoroutine(FadeRoutine(target, duration, 0f));
    }
    public void FadeTo(GameObject target, float duration, float alpha)
    {
        StartCoroutine(FadeRoutine(target, duration, alpha));
    }


    private IEnumerator FadeRoutine(GameObject target, float duration, float targetAlpha)
    {
        if (target == null) yield break;

        float elapsedTime = 0f;

        if (target.TryGetComponent<TMP_Text>(out TMP_Text text))
        {
            float startAlpha = text.color.a;
            Color startColor = text.color;
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / duration);
                text.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
                yield return null;
            }
            text.color = new Color(startColor.r, startColor.g, startColor.b, targetAlpha);
        }

        else if (target.TryGetComponent<RawImage>(out RawImage img))
        {
            float startAlpha = img.color.a;
            Color startColor = img.color;
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / duration);
                img.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
                yield return null;
            }
            img.color = new Color(startColor.r, startColor.g, startColor.b, targetAlpha);
        }

        else if (target.TryGetComponent<CanvasGroup>(out CanvasGroup canvas))
        {
            float startAlpha = canvas.alpha;
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / duration);
                canvas.alpha = alpha;
                yield return null;
            }
            canvas.alpha = targetAlpha;
        }
    }
}
