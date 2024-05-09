using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class UIComponent
{
    public string Key;
}

[Serializable]
public class ButtonComponent : UIComponent
{
    public Button Button;
}

[Serializable]
public class InputComponent : UIComponent
{
    public TMP_InputField Input;
}