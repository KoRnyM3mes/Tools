using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Minion")]
public class MySO : ScriptableObject
{
   public new string name;
   
   public int hp;
   public int dmg;
   public int speed;

   public void Log()
   {
      Debug.Log(name + "has spawned");
   }

}
