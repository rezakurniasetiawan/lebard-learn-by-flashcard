using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Line3 : MonoBehaviour
{
    // Start is called before the first frame update
    Coroutine drawing;
    public float lineWidth = 0.2f;
    public Color lineColor = Color.white;
    public bool changeColor = false;
    public List<GameObject> lines = new List<GameObject>();

    public GameObject benar, selesai;
    public int Score;

    public Image targetImage;

    public bool delete,red,green,blue;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
        
            StartLine();

        }
        else if (Input.GetMouseButtonUp(0))
        {
            FinishLine();
        }
        
        if (changeColor)
        {
            UpdateLineColor();
        }

        Debug.Log(changeColor);

        if(Score == 1){
            selesai.SetActive(true);
        }
    }
    
    void StartLine()
    {
        if (drawing != null)
        {
            StopCoroutine(drawing);
            benar.SetActive(false);
        }
        if (targetImage != null && RectTransformUtility.RectangleContainsScreenPoint(targetImage.rectTransform, Input.mousePosition))
        {
            GameObject lineObject = Instantiate(Resources.Load("Line") as GameObject, new Vector3(0, 0, 0), Quaternion.identity);
            
            lines.Add(lineObject);
            
            drawing = StartCoroutine(DrawLine(lineObject));
        }
    }

    void FinishLine()
    {
        if (drawing != null)
        {
            StopCoroutine(drawing);
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            GameObject hitObject = hit.collider.gameObject;

            // Jalankan fungsi sesuai dengan objek yang disentuh
            if (hitObject.CompareTag("Dua"))
            {
                // CubeFunction();
                Debug.Log("Sentuh 2");
                benar.SetActive(true);
                Score++;
            }
        }
        }
        
    }

    
    IEnumerator DrawLine(GameObject lineObject)
    {
        LineRenderer line = lineObject.GetComponent<LineRenderer>();
        line.positionCount = 0;
        line.startWidth = lineWidth;
        line.endWidth = lineWidth;
        line.startColor = lineColor;
        line.endColor = lineColor;

        while (true)
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = 0;
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, position);
            yield return null;
        }
    }

     void YourFunctionToExecute()
    {
        // Implement your function logic here
    }

    void UpdateLineColor()
    {
        GameObject lineObject = GameObject.Find("Line");
        if (lineObject != null)
        {
            LineRenderer line = lineObject.GetComponent<LineRenderer>();
            line.startColor = lineColor;
            line.endColor = lineColor;
        }
    }

    void DeleteLastLine(int index)
    {
        if (index >= 0 && index < lines.Count)
        {
            GameObject lineObject = lines[index];
            lines.RemoveAt(index);
            Destroy(lineObject);
        }
    }

    void ChangeLineColor(Color color)
    {
        lineColor = color;
        changeColor = true;
        UpdateLineColor();
    }

    public void tombolHapus()
    {
        delete = true;
        red = false;
        blue = false;
        green = false;
        DeleteLastLine(lines.Count - 1);
    }
    public void warnaMerah()
    {
        ChangeLineColor(Color.red);
        delete = false;
    }

    public void warnaBiru()
    {
        ChangeLineColor(Color.blue);
        delete = false;
    }

    public void warnaHijau()
    {
        ChangeLineColor(Color.green);
        delete = false;
    }
    public void warnaKunig()
    {
        ChangeLineColor(Color.yellow);
        delete = false;
    }
}
