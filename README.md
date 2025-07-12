# UniLesson01

https://majimun-kobo.github.io/unilesson.github.io/unilesson/games/unilesson01/

操作方法
左クリック：ジャンプ

概要


## 準備
### プロジェクトの作成
新規プロジェクトを作ります。  
・テンプレート：Universal 2D  
・プロジェクト名：UniLesson01  
・保存場所を決めて下さい。  
・プロジェクトを作成  

Unityのエディター画面が開いたら準備完了です  

### 画面の設定  
ゲーム画面のアスペクト比を「16:9」に設定します。  

### フォルダの作成
「プロジェクトメニュー」⇒「Create」⇒「Folder」から以下のフォルダを作成します。  
・Audio  
・Prefabs  
・Materials  
・Scripts  
・Textures  

## プレイヤーの作成
プレイヤーキャラクターを作りましょう。  

### オブジェクトの生成
「ヒエラルキーメニュー」⇒「2D Object」⇒「Sprites」⇒「Square」からプレイヤーとなるオブジェクトを生成します。  
オブジェクトの名前を「Player」に変更しましょう。  

オブジェクトにコンポーネントを追加します。  
・Box Collider 2D...四角い衝突判定を追加するコンポーネント  
・Rigidbody 2D...物理的な動きを追加するコンポーネント  
・Audio Source...音を出すコンポーネント  

### スクリプトの生成
「プロジェクトメニュー」⇒「Create」⇒「MonoBehaviour Script」からプレイヤーのスクリプトを作成します。  
ファイル名を「PlayerController」に変更しましょう。  

スクリプトを作成したら、
