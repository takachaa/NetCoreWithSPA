module.exports = {
    root: true,
    parserOptions: {
        parser: 'babel-eslint'
    },
    env: {
        browser: true,
    },
    extends: [
        // ここに既存の設定やプリセットを追加します
        'plugin:vue/recommended'  // Vueの推奨設定を適用
    ],
    rules: {
        'vue/multi-word-component-names': 'off' // このルールを無効にする
    }
};