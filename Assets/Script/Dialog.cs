using System;

[Serializable]
public class Dialog {

    public int id;
    public string charName;
    public string text;
    public string pathCharacter;
    public string pathScene;
    public int[] songs;
    public string[] decisions;
    public int mutiple;
    public int[] nextId;
    public string[] idItem;
    
}

[Serializable]
public class GameDialogs
{
    public Dialog[] gameDialog;
}