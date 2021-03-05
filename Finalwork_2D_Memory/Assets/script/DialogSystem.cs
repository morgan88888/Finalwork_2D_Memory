using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogSystem : MonoBehaviour
{
    [Header("UI組件")]
    public Text textLabel;
    public Image faceFile;

    [Header("文本文件")]
    public TextAsset textFile;
    public int index;
    public float textSpeed;

    bool textFinished;

    List<string> TextList = new List<string>();

    public List<string> TextList1 { get => TextList; set => TextList = value; }

    void Awake()
    {
        GetTextFromFile(textFile);
    }
    private void OnEnable()
    {
        //textLabel.text = TextList(index);
        //index++;
        textFinished = true;
        StartCoroutine(SetTextUI());

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && index == TextList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }

        if(Input.GetKeyDown(KeyCode.Space) && textFinished)
        {
            //textLabel.text = TextList(index);
            //index++;
            StartCoroutine(SetTextUI());
        }
    }

    void GetTextFromFile(TextAsset file)
    {
        TextList.Clear();
        index = 0;

        var lineData = file.text.Split('\n');

        foreach (var line in lineData)
        {
            TextList.Add(line);
        }
    }

    IEnumerator SetTextUI()
    {
        textFinished = false;
        textLabel.text = "";

        for (int i = 0; i < TextList[index].Length; i++)
        {
            textLabel.text += TextList[index][i];

            yield return new WaitForSeconds(textSpeed);
        }

        textFinished = true;
        index++;
    }
}
