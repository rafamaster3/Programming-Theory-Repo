using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cylinder : Player // INHERITANCE
{
    private string m_Name ="Cylinder"; 
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private TextMeshProUGUI outputText;
    [SerializeField] private GameObject shapeText;

    public string Name // ENCAPSULATION
    {
        get { return m_Name;  }
        set
        {
            if (value.Length < 9)
            {
                m_Name = value;
            }
            
        }
    }

   
    public override void Action() // POLYMORPHISM
    {
        Name = inputText.text;
        outputText.text = Name;
        
    }

    
}
