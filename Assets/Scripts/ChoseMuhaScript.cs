using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static UnityEngine.Mathf;

public class ChoseMuhaScript : MonoBehaviour
{
    [SerializeField] private GameObject blackScreen;
    [SerializeField] private GameObject textTop;
    [SerializeField] private GameObject textMiddle;
    [SerializeField] private GameObject textBottom;
    [SerializeField] private GameObject dialogueBar;
    [SerializeField] private GameObject textDialogue;
    [SerializeField] private GameObject characterLeft;
    [SerializeField] private GameObject characterRight;
    [SerializeField] private GameObject buttonGood;
    [SerializeField] private GameObject buttonBad;
    [SerializeField] private Texture2D[] FranklinTextures;
    [SerializeField] private Texture2D[] MaryTextures;
    [SerializeField] private Texture2D[] AnotherMuhaTextures;
    [SerializeField] private Texture2D[] IecheHuhaTextures;

    void Start()
    {

        StartCoroutine(PlayMarySequence());
    }

    IEnumerator PlayMarySequence()
    {

        //textTop.GetComponent<TMP_Text>().text = "\n\n\nВнимание Франклина привлекла <b>красивая муха</b>";

        //GameUtils.Instance.FadeIn(textTop, 1f);

        //yield return new WaitForSeconds(2.5f);

        //GameUtils.Instance.FadeOut(textTop, 1f);

        //yield return new WaitForSeconds(1.2f);

        //textTop.GetComponent<TMP_Text>().text = "Маленькая. Тёмно-серая. С розовым бантиком на голове, который выглядел так, будто его повязала сама судьба - идеально, непоколебимо, с вызовом.";

        //GameUtils.Instance.FadeIn(textTop, 1f);

        //yield return new WaitForSeconds(3.5f);

        //textBottom.GetComponent<TMP_Text>().text = "Глаза у неё были розовые и большие и взгляд такой будто точно сейчас точно-точно что-то что-то что-то конкретное попросит. Трудно было пройти мимо нее и не задержать на ней свой взгляд.";

        //GameUtils.Instance.FadeIn(textBottom, 1f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.FadeOut(textTop, 1f);
        //GameUtils.Instance.FadeOut(textBottom, 1f);

        //yield return new WaitForSeconds(1.2f);

        //textBottom.GetComponent<TMP_Text>().text = "Франклин замер и засмотрелся немного. Но после нескольких минут раздумий он решился подойти к ней и заговорить первым, но видимо у нее были свои планы.";

        //GameUtils.Instance.FadeIn(textBottom, 1f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().color = new Color(255, 255, 255);

        //GameUtils.Instance.FadeOut(textBottom, 0.5f);

        //textDialogue.GetComponent<TMP_Text>().text = "\n<color=#f793b8>Мари: </color>";

        //GameUtils.Instance.FadeIn(textDialogue, 0.1f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("О - ой...ещё один день в этой дыре. ");

        //yield return new WaitForSeconds(2f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Как всегда одна. Как всегда, никому не нужна...");

        //yield return new WaitForSeconds(3f);

        //textDialogue.GetComponent<TextTyper>().StartTyping(" Никому я не нужна...");

        //yield return new WaitForSeconds(1.5f);

        //GameUtils.Instance.FadeOut(textDialogue, 0.5f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "\n<color=#ffb790>Франклин: </color>";

        //GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Она... плачет? Нет, не плачет. Просто смотрит так... как будто ей очень грустно.");

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "\n<color=#ffb790>Франклин: </color>";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Хотя, может, ей всегда грустно. У мух иногда бывает такое выражение лица.");

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "\n<color=#ffb790>Франклин: </color>";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Или нет?");

        //yield return new WaitForSeconds(1f);

        //textDialogue.GetComponent<TextTyper>().StartTyping(" Я вообще не разбираюсь в мухах. Я их только кушаю.");

        //yield return new WaitForSeconds(3f);

        //GameUtils.Instance.FadeOut(textDialogue, 0.5f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textBottom.GetComponent<TMP_Text>().text = "Паучок подошел к ее столику и захотел утешить. И спросить, возможно она знает как можно вернуться на чердак.";

        //GameUtils.Instance.FadeIn(textBottom, 1f);

        //yield return new WaitForSeconds(1f);

        ////////////////////////////////////////////////////////////////////////////

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.FadeOut(textBottom, 1f);

        //yield return new WaitForSeconds(0.75f);

        //textDialogue.GetComponent<TMP_Text>().color = new Color(0, 0, 0, 0);

        //GameUtils.Instance.FadeIn(dialogueBar, 1f);

        //yield return new WaitForSeconds(0.75f);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        //GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        //yield return new WaitForSeconds(0.75f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Эй. Эй... Я... можно я присяду? Если ты не против.");

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Паук?        Ты... паук?        \nНаверное, тебе совсем не страшно жить на этом свете. Не то что мне, я такая маленькая и все хотят меня обидеть..");

        //yield return new WaitForSeconds(0.5f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.FadeOut(textDialogue, 0.5f);

        //yield return new WaitForSeconds(0.75f);

        //textDialogue.GetComponent<TMP_Text>().text = "\n\nОна посмотрела на его перевязанную лапку. И что-то в её взгляде изменилось - стал мягче, теплее.";

        //GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        //yield return new WaitForSeconds(2.5f);

        //GameUtils.Instance.FadeOut(textDialogue, 0.5f);

        //yield return new WaitForSeconds(0.75f);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        //GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Ой... лапка... У тебя лапка перевязана.  ");

        //yield return new WaitForSeconds(2.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Это же... больно? Тебе больно?");

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Ой, мне так жаль, я просто... я не могу видеть, когда кому-то плохо. Я такая чувствительная. Мне буквально больно смотреть на твою лапку");

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Нет, нет, не беспокойся, все хорошо, это давно было...");

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Слушай, а ты случайно не знаешь, как выбраться отсюда?    \nМне нужно вернуться, не могла бы ты мне помочь?");

        //yield return new WaitForSeconds(0.5f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Да, конечно, знаю.        \nЯ знаю много путей и как выйти там откуда пришел и откуда ушел, но за пределами нашего городка неспокойно. Идти в одиночку опасно!");

        //yield return new WaitForSeconds(0.5f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Может... ");

        //yield return new WaitForSeconds(0.5f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Может, ты не будешь прятаться один?        \nВдруг тебе станет ещё хуже, и никого рядом не будет..?");

        //yield return new WaitForSeconds(0.5f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("Я понимаю, если не хочешь. Я привыкла быть одна... ");

        //yield return new WaitForSeconds(4f);

        //textDialogue.GetComponent<TextTyper>().StartTyping("     \nСовсем одна...");

        //yield return new WaitForSeconds(0.5f);

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.FadeOut(textDialogue, 0.5f);

        //yield return new WaitForSeconds(0.5f);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\nТы же возьмёшь меня с собой?";

        //GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        //buttonGood.SetActive(true);
        //buttonBad.SetActive(true);

        //GameUtils.Instance.FadeIn(buttonBad, 0.5f);
        //GameUtils.Instance.FadeIn(buttonGood, 0.5f);

        //yield return new WaitForSeconds(0.5f);

        //yield return new WaitUntil(() => Gamedata.lastChoice != 0);

        //buttonBad.GetComponent<Button>().interactable = false;
        //buttonGood.GetComponent<Button>().interactable = false;

        //GameUtils.Instance.FadeOut(buttonBad, 0.5f);
        //GameUtils.Instance.FadeOut(buttonGood, 0.5f);

        //buttonGood.SetActive(false);
        //buttonBad.SetActive(false);

        //yield return new WaitForSeconds(1f);

        //if (GameData.karma == 1)
        //{
        //    StartCoroutine(BeGood());
        //}
        //else
        //{
        //    StartCoroutine(BeBad());
        //}

        //Gamedata.lastChoice = 0;

        ////////////////////////////////////////////////// ВСЁ НИЖЕ УБРАТЬ

        //yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        //GameUtils.Instance.FadeIn(dialogueBar, 0.5f);

        //textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\nТы же возьмёшь меня с собой?";

        //GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        //buttonGood.SetActive(true);
        //buttonBad.SetActive(true);

        //GameUtils.Instance.FadeIn(buttonBad, 0.5f);
        //GameUtils.Instance.FadeIn(buttonGood, 0.5f);

        //yield return new WaitForSeconds(0.5f);

        //yield return new WaitUntil(() => Abs(GameData.karma) == 1);

        //buttonBad.GetComponent<Button>().interactable = false;
        //buttonGood.GetComponent<Button>().interactable = false;

        //GameUtils.Instance.FadeIn(dialogueBar, 0.1f);
        //GameUtils.Instance.FadeIn(textDialogue, 0.1f);

        //GameUtils.Instance.FadeOut(buttonBad, 0.5f);
        //GameUtils.Instance.FadeOut(buttonGood, 0.5f);

        //yield return new WaitForSeconds(1f);

        //buttonGood.SetActive(false);
        //buttonBad.SetActive(false);

        //if (GameData.karma == 1)
        //{
        //    StartCoroutine(BeGood());
        //}
        //else
        //{
        //    StartCoroutine(BeBad());
        //}

        //yield return new WaitUntil(() => Abs(GameData.karma) == 1);

        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Koridor());
    }

    IEnumerator BeGood()
    {
        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Конечно, я никогда не против компании и бросать тебя я тоже не хочу. Тем более вместе не так страшно!");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Меня зовут Франклин, кстати. А ты?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Франклин...     \nТакое... необычное имя. Мне нравится.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("На самом деле, мое полное имя звучит так: ...");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Сер Сан Франклин-Паук Фон Вон Цу-унд-цу Де Биерхорлс-Ейшеро О’Мире младший.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "\n<i>Пауза, Мари в афиге тихо</i>";

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        yield return new WaitForSeconds(2f);

        GameUtils.Instance.FadeOut(textDialogue, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("О-ого.. Не обычное имя.         \nА я Мари. Просто Мари. ");

        yield return new WaitForSeconds(4.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я же такая маленькая и лапки такие у меня маленькие...   \nНо ты, наверное, быстро забудешь.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Почему бы мне забыть?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Все забывают, никто меня не любит, и не помнит, никто.");

        yield return new WaitForSeconds(3.5f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Это ничего...");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        StartCoroutine(Koridor());
    }

    IEnumerator BeBad()
    {
        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ладно. Но только потому, что мне нужен местный ориентир. И ты не будешь путаться под ногами.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Whatever. Мне нужно на чердак.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("На... чердак?      \nОй. Это так высоко. Тебе не страшно?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Хотя тебе, наверное, ничего не страшно. Ты же такой... паук и сильный...");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Именно. Так ты знаешь дорогу или нет?");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Может, знаю, а может нет...");

        yield return new WaitForSeconds(2f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Но давай... попробуем вместе.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        StartCoroutine(Koridor());
    }

    IEnumerator Koridor()
    {
        RectTransform rt;

        GameUtils.Instance.FadeOut(textDialogue, 0.5f);
        GameUtils.Instance.FadeOut(dialogueBar, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textTop.GetComponent<TMP_Text>().text = "Квартира с точки зрения маленького паука - это целый материк.";

        GameUtils.Instance.FadeIn(textTop, 0.75f);

        yield return new WaitForSeconds(1.5f);

        rt = textMiddle.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(-64, 99);

        textMiddle.GetComponent<TMP_Text>().text = "\nКовёр - густые джунгли ворса, в которых можно потеряться навсегда";

        GameUtils.Instance.FadeIn(textMiddle, 0.75f);

        yield return new WaitForSeconds(2f);

        textBottom.GetComponent<TMP_Text>().text = "\n\n\n\n\nПлинтус - единственная надёжная дорога, узкая и пыльная, но хотя бы понятная.\r\n";

        GameUtils.Instance.FadeIn(textBottom, 0.75f);

        yield return new WaitForSeconds(1f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textTop, 0.5f);
        GameUtils.Instance.FadeOut(textMiddle, 0.5f);
        GameUtils.Instance.FadeOut(textBottom, 0.5f);

        ///////////////////////////////////////////////////////////////
        
        yield return new WaitForSeconds(1f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n<i>[гордо двигается со знанием своего пешего дела]</i>";

        GameUtils.Instance.FadeIn(textDialogue, 0.5f);
        GameUtils.Instance.FadeIn(dialogueBar, 0.5f);

        yield return new WaitForSeconds(3f);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ты слишком медленно идешь и громко топаешь, голова болит от тебя уже!");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("А почему бы тебе не лететь немного впереди, я же за тобой иду?");

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Я и так делаю тебе одолжение тем, что сопровождаю тебя, будь благодарен!");

        /////////////////////////////////////////////////////////////////
       
        yield return new WaitForSeconds(1f);

        buttonGood.SetActive(true);
        buttonBad.SetActive(true);

        buttonGood.GetComponentInChildren<TMP_Text>().text = "Ты права... Буду тише";
        buttonBad.GetComponentInChildren<TMP_Text>().text = "Ты сама напросилась в попутчики!";

        buttonBad.GetComponent<Button>().interactable = true;
        buttonGood.GetComponent<Button>().interactable = true;

        GameUtils.Instance.FadeIn(buttonBad, 0.5f);
        GameUtils.Instance.FadeIn(buttonGood, 0.5f);

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => GameData.lastChoice != 0);

        

        GameUtils.Instance.FadeOut(buttonBad, 0.5f);
        GameUtils.Instance.FadeOut(buttonGood, 0.5f);

        yield return new WaitForSeconds(1f);

        if (GameData.lastChoice == 1)
        {
            StartCoroutine(AgreeMary());
        }
        else
        {
            StartCoroutine(DisagreeMary());
        }

        GameData.lastChoice = 0;
    }

    IEnumerator AgreeMary()
    {
        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ладно, ты права... Буду вести себя потише.");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("То-то же, я всегда права. Слушай меня почаще.        \nТут осталось совсееем немного. Так сказать Чуть-чуть");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        StartCoroutine(HumanScene());
    }
    IEnumerator DisagreeMary()
    {
        textDialogue.GetComponent<TMP_Text>().text = "<color=#ffb790>        Франклин:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Так ты сама напросилась в попутчики, так что не возмущайся!");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        textDialogue.GetComponent<TMP_Text>().text = "<color=#f793b8>        Мари:</color>\n";

        yield return new WaitForSeconds(0.5f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Ну я же стараюсь. Аххх~ ");

        yield return new WaitForSeconds(1.3f);

        textDialogue.GetComponent<TextTyper>().StartTyping("Никто меня не ценит. Умру от одиночества прям тут и тогда посмотрим, как ты без меня");

        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        StartCoroutine(HumanScene());
    }

    IEnumerator HumanScene()
    {
        GameUtils.Instance.FadeOut(textDialogue, 0.5f);
        GameUtils.Instance.FadeOut(dialogueBar, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textTop.GetComponent<TMP_Text>().text = "Споры парочки заставили плинтус слегка дрожать.";

        GameUtils.Instance.FadeIn(textTop, 0.75f);

        yield return new WaitForSeconds(1.5f);

        textMiddle.GetComponent<TMP_Text>().text = "Это не могло не привлечь <b>чье-то</b> внимание.";

        GameUtils.Instance.FadeIn(textMiddle, 0.75f);

        yield return new WaitForSeconds(2f);

        textBottom.GetComponent<TMP_Text>().text = "\n\n\n\n\n\nВдруг, они услышали шаги.";

        GameUtils.Instance.FadeIn(textBottom, 0.75f);

        yield return new WaitForSeconds(1f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textTop, 0.5f);
        GameUtils.Instance.FadeOut(textMiddle, 0.5f);
        GameUtils.Instance.FadeOut(textBottom, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textTop.GetComponent<TMP_Text>().text = "Они нарастали.";

        GameUtils.Instance.FadeIn(textTop, 0.75f);

        yield return new WaitForSeconds(1.5f);

        textMiddle.GetComponent<TMP_Text>().text = "Франклин и Мари посмотрели в сторону откуда доносится звук и увидели перед собой….";

        GameUtils.Instance.FadeIn(textMiddle, 0.75f);

        yield return new WaitForSeconds(2.3f);

        textBottom.GetComponent<TMP_Text>().text = "\n\n\n\nНоги - огромные, в носках с принтом какой-то\n очень <i>(или не очень)</i> прекрасной дивы, уверенно поступающие по ламинату.";

        GameUtils.Instance.FadeIn(textBottom, 0.75f);

        yield return new WaitForSeconds(1f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textTop, 0.5f);
        GameUtils.Instance.FadeOut(textMiddle, 0.5f);
        GameUtils.Instance.FadeOut(textBottom, 0.5f);

        yield return new WaitForSeconds(0.75f);

        textTop.GetComponent<TMP_Text>().text = "За ногами следовала рука, в которой болтался он.";

        GameUtils.Instance.FadeIn(textTop, 0.75f);

        yield return new WaitForSeconds(1.5f);

        textMiddle.GetComponent<TMP_Text>().color = new Color(255, 0, 0, 0);

        textMiddle.GetComponent<TMP_Text>().fontSize = 300;

        textMiddle.GetComponent<TMP_Text>().text = "\n<b>Тапок</b>";

        GameUtils.Instance.FadeIn(textMiddle, 1.75f);

        yield return new WaitForSeconds(3.5f);

        textBottom.GetComponent<TMP_Text>().text = "\n\n\n\n\nПлоский. Резиновый. С видом существа, которое чего-то ждёт злобной пастью открытой подошвы, заглядывающий прямо в душу.";

        GameUtils.Instance.FadeIn(textBottom, 0.75f);

        yield return new WaitForSeconds(1f);

        yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);

        GameUtils.Instance.FadeOut(textTop, 0.5f);
        GameUtils.Instance.FadeOut(textMiddle, 0.5f);
        GameUtils.Instance.FadeOut(textBottom, 0.5f);

        yield return new WaitForSeconds(0.6f);

        textMiddle.GetComponent<TMP_Text>().color = new Color(255,255,255, 0);

        textMiddle.GetComponent<TMP_Text>().fontSize = 80;

        //Запуск сцены с игрой про тапок
    }

}