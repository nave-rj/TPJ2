# AV1 (3pts)

## Editor de Tabela

Crie um custom editor (dentro de uma pasta "Editor" na Unity) de um MonoBehaviour que contém uma * tabela.

*A tabela é, na verdade, um List<Entry>:

```csharp
[System.Serializable]
public class Entry
{
  public string key;
  public int value;
}
```

^ Cole essa classe ao lado de sua classe MonoBehaviour

## Dicas pr0

Você provavelmente vai usar o EditorGUILayout.IntField

```csharp
v = EditorGUILayout.IntField( "label", v );
```

## EXTRAS
- Fazer botão de adicionar elemento (Entry)
- Fazer botão de remover elemento (Entry)

## Logística
- Grupos de 2 a 4 pessoas
- Enviar para mlr@cesar.org.br
- Assunto: "AV1 3bi 3003"
- Nome do grupo no email
- Apenas um email por grupo
