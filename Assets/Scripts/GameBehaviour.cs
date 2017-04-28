using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour {
    public int xsize, ysize;
    public GameObject Node;
    public int size;
    private GameObject Grid;
    List<GameObject> gameobjects;
    private Vector3[] vertices;
    public int NodeOffset;
    

    private void Generate()
    {
        vertices = new Vector3[(xsize + 1) * (ysize + 1)];
        for (int i = 0, y = 0; y <= ysize; y++)
        {
            for (int x = 0; x <= xsize; x++, i++)
            {
                vertices[i] = new Vector3(x, y);
            }
        }
    }
    private void Awake()
    {
        Generate();
    }
    void Start() {
        for (int rows = 0; rows < size; rows++)
        {
            for(int cols = 0; cols < size; cols++)
            {
                Vector3 pos = new Vector3(rows * NodeOffset, 0, cols * NodeOffset);
                var thing  = Instantiate(Node, pos, Node.transform.rotation);
                gameobjects.Add(thing);
            }
        }
      
	
	//void Update () {
		
	}
}
