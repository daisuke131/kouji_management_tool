drop table m_hanyou;
create table m_hanyou (
        mst_kbn                       varchar(255)              not null,
        han_cd                        varchar(10)               not null,
        han_name                      varchar(500),
        koumoku1                      varchar(100),
        koumoku2                      varchar(100),
        koumoku3                      varchar(100),
        koumoku4                      varchar(100),
        koumoku5                      varchar(100),
        sort_key                      varchar(20),
constraint pk_m_hanyou primary key (mst_kbn,han_cd)
);
