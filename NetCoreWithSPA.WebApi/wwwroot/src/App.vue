<template>
    <div>
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container-fluid">
                <a class="navbar-brand ml-4" href="#">MyApp</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse justify-content-end mr-4" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item active">
                            <router-link class="nav-link" to="/" @click="collapseNav">Home</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link class="nav-link" to="/detail" @click="collapseNav">Details</router-link>
                        </li>
                        <li class="nav-item active">
                            <router-link class="nav-link" to="/register" @click="collapseNav">Register</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link class="nav-link" to="/login" @click="collapseNav">Login</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link class="nav-link" to="/weather" @click="collapseNav">Weather</router-link>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>

        <!-- Route Views -->
        <router-view></router-view>
    </div>
</template>

<script>
    export default {
        name: 'App',
        methods: {
            collapseNav() {
                const navbarToggler = document.querySelector('.navbar-toggler');
                if (!navbarToggler.classList.contains('collapsed')) {
                    navbarToggler.click();
                }
            }
        }
    };
</script>

<style scoped>
    /* 任意のスタイルを追加します。必要に応じてカスタマイズしてください。 */
</style>