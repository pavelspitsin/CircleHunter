using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


class CircleGeometryInfo
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
}


class GameSpaceSize
{
    public float Left { get; private set; }
    public float Right { get; private set; }
    public float Bottom { get; private set; }
    public float Top { get; private set; }

    public GameSpaceSize(float l, float r, float b, float t)
    {
        Left = l;
        Right = r;
        Bottom = b;
        Top = t;
    }
}


public class CircleSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject greenCircle_Prefab;

    [SerializeField]
    private GameObject redCircle_Prefab;

    [SerializeField]
    private GameObject UIPanel;



    private GameSpaceSize _spaceSize;

    private Vector2 _greenCircleSize;
    private Vector2 _redCircleSize;



    // Use this for initialization
    void Start() {

        _spaceSize = GetGameSpaceSize();

        _greenCircleSize = greenCircle_Prefab.GetComponent<SpriteRenderer>().bounds.size;
        _redCircleSize = redCircle_Prefab.GetComponent<SpriteRenderer>().bounds.size;

        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    void Update() {
    }


    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            RandomSpawn(greenCircle_Prefab, _greenCircleSize, 1);

            if (Random.Range(0f, 1f) < 0.2)
                RandomSpawn(redCircle_Prefab, _redCircleSize, 1);

            yield return new WaitForSeconds(0.5f);
        }
    }


    private CircleGeometryInfo RandomSpawn(GameObject prefab, Vector2 prefabSize, float timeToInvisible)
    {
        float scale = Random.Range(0.4f, 1.0f);

        float circleWidth = prefabSize.x * scale;
        float circleHeight = prefabSize.y * scale;

        Vector2 position = new Vector2();

        position.x = Random.Range(_spaceSize.Left + circleWidth / 2f, _spaceSize.Right - circleWidth / 2f);
        position.y = Random.Range(_spaceSize.Bottom + circleHeight / 2f, _spaceSize.Top - circleHeight / 2f);   


        return SpawnCircle(prefab, position, scale, timeToInvisible);
    }
    

    private CircleGeometryInfo SpawnCircle(GameObject prefab, Vector2 position, float scale, float timeToInvisible)
    {
        GameObject circle = Instantiate(prefab, position, Quaternion.identity);
        circle.GetComponent<FadeCircleComponent>().Fade(timeToInvisible);

        Vector3 localScale = circle.transform.localScale;
        localScale.x *= scale;
        localScale.y *= scale;
        circle.transform.localScale = localScale;

        Vector3 circleSize = circle.GetComponent<SpriteRenderer>().bounds.size;

        return new CircleGeometryInfo()
        {
            X = position.x,
            Y = position.y,
            Width = circleSize.x,
            Height = circleSize.y
        };
    }


    private GameSpaceSize GetGameSpaceSize()
    {

        CanvasScaler scaler = UIPanel.GetComponentInParent<CanvasScaler>();

        float match = scaler.matchWidthOrHeight;
        Vector2 refResolution = scaler.referenceResolution;

        float scaleFactorWidth = Screen.width / refResolution.x;
        float scaleFactorHeight = (Screen.height / refResolution.y);
        // float scaleFactor = (1 - match) * scaleFactorWidth + match * scaleFactorHeight;
        float scaleFactorExp =  Mathf.Exp(((1 - match) * Mathf.Log(scaleFactorWidth) + match * Mathf.Log(scaleFactorHeight)));

        float uiHeight = UIPanel.GetComponent<RectTransform>().rect.height * (float)scaleFactorExp;

        Vector3 rightTop = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height - uiHeight));
        Vector3 leftBottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 0));

        return new GameSpaceSize(leftBottom.x, rightTop.x, leftBottom.y, rightTop.y);
    }
}
