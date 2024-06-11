using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrDistribui : MonoBehaviour
{
     public GameObject prefab; // O prefab que será distribuído
    public int numPrefabs = 10; // O número de prefabs a serem distribuídos
    public float areaWidth = 28f; // Largura da área
    public float areaHeight = 12f; // Altura da área
    public float minSpacing = 2f; // Espaçamento mínimo entre os prefabs

    private void Start()
    {
        DistributePrefabs();
    }

    void DistributePrefabs()
    {
        // Lista para armazenar as posições dos prefabs já posicionados
        var positions = new System.Collections.Generic.List<Vector2>();

        for (int i = 0; i < numPrefabs; i++)
        {
            Vector2 newPos;
            int attempts = 0;

            // Tentar encontrar uma posição válida
            do
            {
                newPos = new Vector2(
                    Random.Range(-areaWidth / 2, areaWidth / 2),
                    Random.Range(-areaHeight / 2, areaHeight / 2)
                ) + (Vector2)transform.position;
                attempts++;

                // Se muitas tentativas falharem, diminuímos o espaçamento
                if (attempts > 100)
                {
                    minSpacing -= 0.1f;
                    attempts = 0;
                }

            } while (!IsPositionValid(newPos, positions));

            positions.Add(newPos);
            Instantiate(prefab, newPos, Quaternion.identity);
        }
    }

    bool IsPositionValid(Vector2 pos, System.Collections.Generic.List<Vector2> positions)
    {
        foreach (Vector2 p in positions)
        {
            if (Vector2.Distance(p, pos) < minSpacing)
            {
                return false;
            }
        }
        return true;
    }

    private void OnDrawGizmos()
    {
        // Desenhar a área ocupada como um retângulo, considerando a posição do GameObject
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector2(areaWidth, areaHeight));
    }
}
