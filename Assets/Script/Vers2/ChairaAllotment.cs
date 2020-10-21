using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairaAllotment : MonoBehaviour
{
    public List<Transform> chair;

    public List<int> indexSave;

    public List<BotAI> botAis;
    public int lastSpawnPointIndex;
    private bool found;
    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            MoveBot();
        }
    }
    
    private void MoveBot()
    {
        indexSave=new List<int>(1);
        for (int i = 0; i < botAis.Count; i++)
        {
            var b = botAis[i];
            Vector3 spawnPoint = GetNextSpawnPoint(b.lastPointIndex);
            b.Move(spawnPoint,lastSpawnPointIndex);
        }
        indexSave.Clear();
    }
    
    private Vector3 GetNextSpawnPoint(int pointIndex)
    {
        int index;
        
        do
        {
             index = (pointIndex + Random.Range(1, chair.Count - 1)) % chair.Count;
        } while (indexSave.Contains(index));
        
        lastSpawnPointIndex = index;
        Vector3 t = chair[index].position;
        Vector3 v = new Vector3(t.x,0,t.z);
        indexSave.Add(index);
        return v;
    }
    
}
