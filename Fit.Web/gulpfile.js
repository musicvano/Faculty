const { src, dest, series, parallel, watch } = require('gulp');
const sass = require('gulp-sass');
const sourcemaps = require('gulp-sourcemaps');

function clean(cb) {
    cb();
}

function styles(cb) {
    src(['ClientApp/main.scss'])
        .pipe(sourcemaps.init())
        .pipe(sass(/*{ outputStyle: 'compressed' }*/).on('error', sass.logError))
        .pipe(sourcemaps.write('.'))
        .pipe(dest('wwwroot/dist'));
    cb();
}

function scripts(cb) {
    src(['ClientApp/main.js', 'node_modules/feather-icons/dist/feather.js'])
        //.pipe(terser())
        .pipe(dest('wwwroot/dist'));
    cb();
}

function dev(cb) {
    watch(['ClientApp/**/*.scss', 'ClientApp/**/*.sass', 'ClientApp/**/*.css'], styles);
    cb();
}

exports.build = series(clean, parallel(styles, scripts));
exports.watch = dev;