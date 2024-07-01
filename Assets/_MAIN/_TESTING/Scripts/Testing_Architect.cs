using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        string[] lines = new string[4]
        {
            "why ",
            "퇴근하고 싶어요",
            "연금복권 당첨시켜주세요",
            "다시 태어날래요",
        };

        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.typewriter;
        }

        // Update is called once per frame
        void Update()
        {
            string longLine = "this is a very long line that makes no sense but I am just populating it with stuff because, you know, stuff is good right? I like stuff, you like stuff, we all like stuff and the turkey gets stuffed.";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (architect.isBuilding)
                {
                    if (!architect.hurryUp)
                        architect.hurryUp = true;
                    else
                        architect.ForceComplete();
                }
                else
                    architect.Build(longLine);
                // architect.Build(lines[Random.Range(0, lines.Length)]);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                architect.Append(longLine);
                // architect.Append(lines[Random.Range(0, lines.Length)]);
            }
        }
    }
}

