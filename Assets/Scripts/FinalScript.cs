using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class FinalScript : MonoBehaviour
{
    [SerializeField] private GameObject blackScreen;
    [SerializeField] private GameObject textTop;
    [SerializeField] private GameObject textMiddle;
    [SerializeField] private GameObject textBottom;
    [SerializeField] private GameObject dialogueBar;
    [SerializeField] private GameObject textDialogue;
    [SerializeField] private GameObject characterLeft;
    [SerializeField] private GameObject characterRight;
    [SerializeField] private GameObject muhaImage;
    [SerializeField] private GameObject backgroundImage;
    [SerializeField] private GameObject franklinImage;
    [SerializeField] private Texture2D[] franklinTextures;
    [SerializeField] private Texture2D[] maryTextures;

    [SerializeField] private Texture2D[] backgrounds;

    void Start()
    {

        GameData.final = 1;

        if (GameData.final == 1)
        {
            StartCoroutine(FinalGoodMary());
        }
        else
        {
            StartCoroutine(FinalBadMary());
        }

        //StartCoroutine(Titles());

        ////StartCoroutine(LadderMary());
    }

    IEnumerator FinalGoodMary()
    {
        backgroundImage.GetComponent<RawImage>().texture = backgrounds[0];

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\n\nПоследний ловкий уворот - прямо в щель, где уже ждала Мари.";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(3.5f);

        GameUtils.Instance.FadeOut(textTop, 1f);
        GameUtils.Instance.FadeOut(textMiddle, 3f);
        GameUtils.Instance.FadeOut(textBottom, 1f);
        GameUtils.Instance.FadeOut(blackScreen, 5f);

        yield return new WaitForSeconds(1f);

        GameUtils.Instance.FadeTo(dialogueBar, 0.75f, 0.8f);

        yield return new WaitForSeconds(0.75f);

        characterLeft.GetComponent<RawImage>().texture = franklinTextures[0];
        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);
        yield return new WaitForSeconds(1f);

        GameUtils.Instance.FadeOut(characterLeft, 1f);
        GameUtils.Instance.FadeOut(characterRight, 1f);

        yield return new WaitForSeconds(1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(characterLeft, 1f);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Красиво. Паутина.");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeIn(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я сам плёл.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textDialogue, 0.5f);
        GameUtils.Instance.FadeOut(characterLeft, 0.5f);
        GameUtils.Instance.FadeOut(characterRight, 0.5f);

        yield return new WaitForSeconds(0.6f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "\nОни сидели и смотрели. То на паутину, то в окошко, то друг на друга.";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(2.75f);

        GameUtils.Instance.FadeOut(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "\nТишина. Хорошая - та, что не требует слов.";

        GameUtils.Instance.FadeIn(textDialogue, 0.75f);

        yield return new WaitForSeconds(0.75f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);
        GameUtils.Instance.FadeIn(characterLeft, 0.5f);
        GameUtils.Instance.FadeIn(characterRight, 0.5f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Про полку...");

        yield return new WaitForSeconds(1.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping(" Я хотела тебе помочь! Правда!");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Но ты не была уверена, что не зашелестит.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("... Неа.");

        yield return new WaitForSeconds(1.5f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeOut(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n<i><color=#a1a1a1>";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("[Она не извинилась. Только сказала правду. Для неё, наверное, это одно и то же.]");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeIn(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Мари. Ты можешь остаться. Если хочешь.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Тут пыльно. И грязно и...");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Но отсюда тебя никто не прогонит.");

        yield return new WaitForSeconds(3.5f);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("... Ладно");

        yield return new WaitForSeconds(0.5f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(dialogueBar, 2.75f);
        GameUtils.Instance.FadeOut(textDialogue, 2.75f);
        GameUtils.Instance.FadeOut(characterLeft, 2.75f);
        GameUtils.Instance.FadeOut(characterRight, 2.75f);
        GameUtils.Instance.FadeIn(blackScreen, 2.55f);

        yield return new WaitForSeconds(2.75f);

        StartCoroutine(Titles());
    }

    IEnumerator FinalBadMary()
    {
        backgroundImage.GetComponent<RawImage>().texture = backgrounds[0];

        textMiddle.GetComponent<TMP_Text>().text = "\n\n\n\n\nФранклин с трудом увильнул от сильного удара тапка, и попал в уже знакомое, родное место.";

        textBottom.GetComponent<TMP_Text>().text = "\n\n\n\nНо чувства были уже не те... Спутница не давала дому ощущуться домом.";

        GameUtils.Instance.FadeIn(textMiddle, 1f);

        yield return new WaitForSeconds(2.5f);

        GameUtils.Instance.FadeIn(textBottom, 1f);

        yield return new WaitForSeconds(2.5f);

        GameUtils.Instance.FadeOut(textTop, 1f);
        GameUtils.Instance.FadeOut(textMiddle, 1f);
        GameUtils.Instance.FadeOut(textBottom, 1f);

        yield return new WaitForSeconds(1f);

        characterLeft.GetComponent<RawImage>().texture = franklinTextures[0];

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeTo(dialogueBar, 0.75f, 0.8f);

        GameUtils.Instance.FadeOut(blackScreen, 0.75f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(characterLeft, 1f);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Франклин?");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeIn(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Чего тебе?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(characterLeft, 1f);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я больше не буду.");

        yield return new WaitForSeconds(1.2f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Наверное.");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeOut(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n<i><color=#a1a1a1>";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("[Она всё ещё не сказала \"прости\". Наверное, для неё \"больше не буду\" - важнее]");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeIn(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ладно.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(characterLeft, 1f);

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Стой что? Ладно?");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.SwapCharacterImages(characterLeft, characterRight);

        GameUtils.Instance.FadeIn(characterRight, 0.1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Каждый заслуживает быть понятым. Ты лишилась дома. Нашла меня. Можешь остаться.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        /////////////////////////////////////////////////////////////////////////////////////////

        GameUtils.Instance.FadeOut(textDialogue, 0.5f);
        GameUtils.Instance.FadeOut(characterLeft, 0.5f);
        GameUtils.Instance.FadeOut(characterRight, 0.5f);
        GameUtils.Instance.FadeIn(blackScreen, 0.75f);

        yield return new WaitForSeconds(1f);

        StartCoroutine(Titles());
    }

    IEnumerator Titles()
    {                  
        textBottom.GetComponent<TMP_Text>().text = "\n\n\n\n\n\n\n\n\n" +
            "<align=center>\"Безымянная история про паучка\"\n</align>" +
            "\n<size=100>Авторы сценария:</size>\n" +
            "   Малюгина Катя\n\n" +
            "   и немного Вика\n" +
            "\n<size=100>Автор идеи:</size>\n" +
            "   Малюгина Катя\n" +
            "\n<size=100>Код:</size>\n" +
            "   Волощенко Илья\n" +
            "   Посаднев Дима\n" +
            "   Anthropic Claude\n\n" +
            "   и немного Вика\n" +
            "\n<size=100>Изображения:</size>\n" +
            "   Малюгина Катя\n" +
            "   OpenAI Image\n\n" +
            "   и немного Вика\n" +
            "\n<size=100>Отдельная благодарность:</size>\n" +
            "   Глицин Форте Эвалар\n" +
            "   Степаниденко Игорь\n" +
            "   Абдулаев Руслан Яхьяевич\n" +
            "   Кофейни Cofix\n" +
            "   Неопознанный летающий объект над Кисловодском\n" +
            "   Серая кошка напротив Колледжа\n" +
            "   Созмультфильм\n" +
            "   Солнышку, за то, что светит\n" +
            "   Энергетик Adrenaline со скидкой по карте лояльности\n" +
            "   bowie_Knife99\n" +
            "   Международный день солидарности эксплуатации детского труда\n" +
            "   Календарь на Июль 1924г.\n" +
            "   Федеральная налоговая служба\n" +
            "   Киркоров Филипп Бедросович\n" +
            "   Тушинская районная поликлиника номер 219\n" +
            "   \"Да пох, норм\"\n" +
            "   Samsung Galaxy S 24 8/256 \"Onyx Black\"\n" +
            "   Линус Торвальдс\n" +
            "   Всем жителям города Ижевск\n" +
            "   Сочетание клавиш Ctrl+Z\n" +
            "   Воздух, которым я дышу (пока бесплатно)\n" +
            "   Автобус номер 313\n" +
            "   Холодильник Indesit\n" +
            "   Президент Российской Федерации\n" +
            "   Сырник\n" +
            "   Сеть магазинов \"Потапыч\"\n" +
            "   Type-C в айфонах, начиная с 15 модели\n" +
            "   МЧС по округу Беларусь\n" +
            "   Социальная сеть Одноклассники\n" +
            "   Кот на aрбузе\n\n" +
            "   и немного Вике\n\n\n <align=center><size=200>Спасибо за игру!";

        GameUtils.Instance.FadeIn(textBottom, 0.1f);
        yield return new WaitForSeconds(0.2f);

        MoveObjectUp(textBottom, 25f, 180f);
        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);
    }

    public void MoveObjectUp(GameObject targetObject, float speed, float duration)
    {
        if (targetObject == null) return;

        // Запускаем корутину, которая будет двигать объект плавно
        StartCoroutine(MoveRoutine(targetObject.transform, speed, duration));
    }

    // Сама корутина для плавного движения
    private IEnumerator MoveRoutine(Transform objTransform, float speed, float duration)
    {
        float elapsed = 0f;

        // Пока не вышло время, двигаем объект каждый кадр
        while (elapsed < duration)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                objTransform.Translate(Vector3.up * speed * 3 * Time.deltaTime);
            }
            else
            {
                objTransform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            // Считаем прошедшее время
            elapsed += Time.deltaTime;

            // Ждем до следующего кадра
            yield return null;
        }
    }
}
