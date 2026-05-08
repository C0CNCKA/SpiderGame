using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class TextTyper : MonoBehaviour
{
    [SerializeField] private TMP_Text typeText;
    [SerializeField] private float typingSpeed = 0.025f;

    private string fullText;
    private string initialText;
    private bool istyping = false;
    private Coroutine typingCoroutine;

    private void Start()
    {   
        if (typeText == null)
            typeText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        if (istyping && (Keyboard.current.spaceKey.wasPressedThisFrame ||
            Keyboard.current.enterKey.wasPressedThisFrame ||
            Mouse.current.leftButton.wasPressedThisFrame))
        {
            StopCoroutine(typingCoroutine);
            istyping = false;
            typeText.text = initialText + fullText;
        }
    }

    public void StartTyping(string newText)
    {
        StopAllCoroutines();
        initialText = typeText.text;
        fullText = newText;
        istyping = true;

        typingCoroutine = StartCoroutine(TypeTextCoroutine());

    }

    public void ClearText()
    {
        typeText.text = "";
    }

    private IEnumerator TypeTextCoroutine()
    {
        foreach (char c in fullText)
        {
            typeText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
        istyping = false;
    }

}
