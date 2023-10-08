module.exports = {
    root: true,
    parserOptions: {
        parser: 'babel-eslint'
    },
    env: {
        browser: true,
    },
    extends: [
        // �����Ɋ����̐ݒ��v���Z�b�g��ǉ����܂�
        'plugin:vue/recommended'  // Vue�̐����ݒ��K�p
    ],
    rules: {
        'vue/multi-word-component-names': 'off' // ���̃��[���𖳌��ɂ���
    }
};