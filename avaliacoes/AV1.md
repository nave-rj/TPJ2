# AV1 (3pts)

## Editor de Tabela

Crie um custom editor (dentro de uma pasta "Editor" na Unity) de um MonoBehaviour que contém uma *tabela.
O editor deve desenhar cada um dos elementos (Entry) do array por linha

*A tabela é, na verdade, um List<Entry>:

```csharp
[System.Serializable]
public class Entry
{
  public string key;
  public int value;
}

public class TabelaBehaviour : MonoBehaviour
{
  public List<Entry> entries = new List<Entry>();
  
  private void Reset()
  {
    entries.Add( new Entry { key = "um elemento", value = 17 } );
    entries.Add( new Entry { key = "outro elemento", value = 43 } );
  }
}
```

^ Cole isso no seu script MonoBehaviour

## Dicas pr0

Você provavelmente vai usar o EditorGUILayout.IntField

```csharp
v = EditorGUILayout.IntField( "label", v );
```

## Referências
- [Editor](https://docs.unity3d.com/ScriptReference/Editor.html)

## Extras
- Fazer botão de adicionar elemento (Entry)
- Fazer botão de remover elemento (Entry)

## Logística
- Grupos de 2 a 4 pessoas
- Enviar para mlr@cesar.org.br
- Assunto: "AV1 3bi 3003"
- Nome do grupo no email
- Apenas um email por grupo
